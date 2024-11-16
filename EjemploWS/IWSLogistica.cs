﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LogisticaWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSLogistica
    {
        [OperationContract]
        Logistica PostCrearOrden(string productos, string detalles);

        [OperationContract]
        Logistica UpdateEstadoOrden(string id, string estado);

        [OperationContract]
        Logistica UpdateOrden(string id, string detalles);

        [OperationContract]
        Logistica DeleteOrden(string id);
        [OperationContract]
        Logistica GetOrden(string id);
        [OperationContract]
        Logistica ListarOrdenes();
    }

    [DataContract]
    public class Logistica {
        [DataMember]
        public string Id { get; set; }  
        [DataMember] 
        public string data { get;set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string fecha { get; set; }
    }
}
