﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.NewProject
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// TestClassNew.
    /// </summary>
    //  *** Start programmer edit section *** (TestClassNew CustomAttributes)

    //  *** End programmer edit section *** (TestClassNew CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class TestClassNew : ICSSoft.STORMNET.DataObject
    {
        
        private string fNew1;
        
        //  *** Start programmer edit section *** (TestClassNew CustomMembers)

        //  *** End programmer edit section *** (TestClassNew CustomMembers)

        
        /// <summary>
        /// New1.
        /// </summary>
        //  *** Start programmer edit section *** (TestClassNew.New1 CustomAttributes)

        //  *** End programmer edit section *** (TestClassNew.New1 CustomAttributes)
        [StrLen(255)]
        public virtual string New1
        {
            get
            {
                //  *** Start programmer edit section *** (TestClassNew.New1 Get start)

                //  *** End programmer edit section *** (TestClassNew.New1 Get start)
                string result = this.fNew1;
                //  *** Start programmer edit section *** (TestClassNew.New1 Get end)

                //  *** End programmer edit section *** (TestClassNew.New1 Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (TestClassNew.New1 Set start)

                //  *** End programmer edit section *** (TestClassNew.New1 Set start)
                this.fNew1 = value;
                //  *** Start programmer edit section *** (TestClassNew.New1 Set end)

                //  *** End programmer edit section *** (TestClassNew.New1 Set end)
            }
        }
    }
}
