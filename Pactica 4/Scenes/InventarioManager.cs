using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioManager : MonoBehaviour {

    [System.Serializable]
    public struct ObjetoInventarioId
    {
        public int id;
        public int cantidad;

        public ObjetoInventarioId(int id, int cantidad){
            this.id = id;
            this.cantidad = cantidad;
        }
        public void AñadirCantidad(int cantidad){
            this.cantidad += cantidad;
        }
    }
    

    public InventarioBaseDatos baseDatos;
    public List<ObjetoInventarioId> inventario;

        public void AgregarAlgoAlInventario(int id, int cantidad)
    {
        for (int i = 0; i < inventario.Count; i++)
        {
            if (inventario[i].id == id)
            {
                inventario[i] = new ObjetoInventarioId(inventario[i].id, inventario[i].cantidad + cantidad);
                ActualizarInventario();
                return;
            }
        }
        inventario.Add(new ObjetoInventarioId(id, cantidad));
        
        ActualizarInventario();
    }

     public void EliminarAlgoDeInventario(int id, int cantidad)
    {
        for (int i = 0; i < inventario.Count; i++)
        {
            if (inventario[i].id == id)
            {
                inventario[i] = new ObjetoInventarioId(inventario[i].id, inventario[i].cantidad - cantidad);
                if (inventario[i].cantidad <= 0)
                    inventario.Remove(inventario[i]);
                ActualizarInventario();
                return;
            }
        }
        Debug.LogError("No existe el objeto a eliminar");
    }

    public void Start(){
        ActualizarInventario();
    }

    public InventarioObjetoInterface  prefab;
    public Transform inventarioUI;
    List<InventarioObjetoInterface> pool = new List<InventarioObjetoInterface>();

    public void ActualizarInventario(){

        print("InventarioActualizado");

        for(int i=0;i<pool.Count;i++){
           if(i < inventario.Count){

            ObjetoInventarioId o = inventario[i];
            pool[i].sprite.sprite=baseDatos.baseDatos[o.id].sprite;
            pool[i].cantidad.text = o.cantidad.ToString();
            pool[i].gameObject.SetActive(true);

            }else{

            pool[i].gameObject.SetActive(false);

            } 
        }

        if(inventario.Count> pool.Count){
            for(int i=pool.Count;i<inventario.Count;i++){

                InventarioObjetoInterface io = Instantiate(prefab,inventarioUI);
                pool.Add(io);
                io.transform.position = Vector3.zero;
                io.transform.localScale = Vector3.one;

                ObjetoInventarioId o = inventario[i];
                pool[i].sprite.sprite=baseDatos.baseDatos[o.id].sprite;
                pool[i].cantidad.text = o.cantidad.ToString();

                pool[i].gameObject.SetActive(true);
            }

        }
       
        
       
    }


}