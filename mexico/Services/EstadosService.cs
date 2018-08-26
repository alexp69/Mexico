using System;
using System.Collections.Generic;
using System.Net.Http;
using mexico.Models;
using Newtonsoft.Json;
using Realms;

namespace mexico.Services
{
    public class EstadosService
    {

     

        public ResultEstados getEstados()
        {
            string url = "http://datamx.io/dataset/73b08ca8-e955-4ea5-a206-ee618e26f081/resource/9c5e8302-221c-46f2-b9f7-0a93cbe5365b/download/estados.json";

            ResultEstados resultEstados = new ResultEstados();
            resultEstados.error = false;

            try
            {
                using (var client = new HttpClient())
                {
                    var task = client.GetStringAsync(url);
                    var json = task.Result;
                    resultEstados.estados = JsonConvert.DeserializeObject<List<Estado>>(json);
                }

            }
            catch 
            {
                resultEstados.error = true;
            }
            return resultEstados;
        }

        public List<Estado> GetAllEstados(){

            var estados = LoadEstados();
            if (estados.Count == 0)
            {
                var result = getEstados();
                if(result.error==false){
                    estados = result.estados;
                    foreach(var _estado in estados){
                        WriteEstado(_estado);
                    }
                }
            }
            if(estados.Count>0 && estados.Count<32){
                DeleteAllEstados();
            }
            return estados;
            
        }

        public List<Estado> LoadEstados()
        {
            var estados = new List<Estado>();
           var _realm = Realm.GetInstance();
            IEnumerable<State> result = _realm.All<State>();
            foreach (var state in result)
            {
                var estado = new Estado() { id = state.id, name = state.name };
                estados.Add(estado);
            }
            return estados;
        }

        public void DeleteAllEstados()
        {
            var _realm = Realm.GetInstance();
            IEnumerable<State> result = _realm.All<State>();
            foreach (var state in result)
            {
                _realm.Write(() => _realm.Remove(state));
            }
        }

        public void WriteEstado(Estado estado)
        {

            var _realm = Realm.GetInstance();

            _realm.Write(() =>
            {

                var state = new State { id = estado.id, name = estado.name };
                _realm.Add(state);
            });
        }


    }

            public class ResultEstados
        {
            public bool error { get; set; }
            public List<Estado> estados { get; set; }

        }
}
