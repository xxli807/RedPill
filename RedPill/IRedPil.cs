using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RedPill
{

    [ServiceContract(Namespace = "http://www.myredpill.somee.com")]
    public interface IRedPill
    {
        [OperationContractAttribute(Action = "http://www.myredpill.somee.com/IRedPill/WhatIsYourToken", ReplyAction = "http://www.myredpill.somee.com/IRedPill/WhatIsYourTokenResponse")]
        System.Guid WhatIsYourToken();



        [OperationContractAttribute(Action = "http://www.myredpill.somee.com/IRedPill/FibonacciNumber", ReplyAction = "http://www.myredpill.somee.com/IRedPill/FibonacciNumberResponse")]
        [FaultContract(typeof(ArgumentOutOfRangeException))]
        long FibonacciNumber(long n);



        [OperationContractAttribute(Action = "http://www.myredpill.somee.com/IRedPill/WhatShapeIsThis", ReplyAction = "http://www.myredpill.somee.com/IRedPill/WhatShapeIsThisResponse")]
        TriangleType WhatShapeIsThis(Int64 a, Int64 b, Int64 c);


        [OperationContractAttribute(Action = "http://www.myredpill.somee.com/IRedPill/ReverseWords", ReplyAction = "http://www.myredpill.somee.com/IRedPill/ReverseWordsResponse")]
        [FaultContract(typeof(ArgumentNullException))]
        string ReverseWords(string s);


    }




    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract(Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType
    {
        [EnumMember]
        Error,
        [EnumMember]
        Equilateral,
        [EnumMember]
        Isosceles,
        [EnumMember]
        Scalene
    }
}
