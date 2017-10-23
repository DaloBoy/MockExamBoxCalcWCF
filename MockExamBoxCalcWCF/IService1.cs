using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MockExamBoxCalcWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// DataContracts så metoderne går igennem.
        /// metoderne kræver værdier i deres paremetre så de kan udføres.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>

        //Udregner Boxens Volumen
        [OperationContract]
        double GetVolume(double length, double width, double height);

        //Udregner Boxens manglende side, hvis Volumen + 2 sider er kendte
        [OperationContract]
        double GetSide(double volume, double side1, double side2);
    }
}
