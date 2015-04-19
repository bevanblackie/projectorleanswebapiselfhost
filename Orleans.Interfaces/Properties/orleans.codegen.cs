//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Orleans.Interfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class HelloFactory
    {
        

                        public static Orleans.Interfaces.IHello GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Orleans.Interfaces.IHello), -1854587754, primaryKey));
                        }

                        public static Orleans.Interfaces.IHello GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Orleans.Interfaces.IHello), -1854587754, primaryKey, grainClassNamePrefix));
                        }

            public static Orleans.Interfaces.IHello Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return HelloReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("Orleans.Interfaces.Orleans.Interfaces.IHello")]
        internal class HelloReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, Orleans.Interfaces.IHello
        {
            

            public static Orleans.Interfaces.IHello Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (Orleans.Interfaces.IHello) global::Orleans.Runtime.GrainReference.CastInternal(typeof(Orleans.Interfaces.IHello), (global::Orleans.Runtime.GrainReference gr) => { return new HelloReference(gr);}, grainRef, -1854587754);
            }
            
            protected internal HelloReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal HelloReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -1854587754;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "Orleans.Interfaces.Orleans.Interfaces.IHello";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                HelloReference input = ((HelloReference)(original));
                return ((HelloReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                HelloReference input = ((HelloReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return HelloReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return ((interfaceId == this.InterfaceId) 
                            || (interfaceId == 1928988877));
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return HelloMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<string> Orleans.Interfaces.IHello.SayHello(string @greeting)
            {

                return base.InvokeMethodAsync<System.String>(-510773597, new object[] {@greeting} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("Orleans.Interfaces.Orleans.Interfaces.IHello", -1854587754)]
    internal class HelloMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -1854587754;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1854587754:  // IHello
                        switch (methodId)
                        {
                            case -510773597: 
                                return ((IHello)grain).SayHello((String)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }case 1928988877:  // IGrainWithIntegerKey
                        switch (methodId)
                        {
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -1854587754:  // IHello
                    switch (methodId)
                    {
                        case -510773597:
                            return "SayHello";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }
                case 1928988877:  // IGrainWithIntegerKey
                    switch (methodId)
                    {
                        
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
