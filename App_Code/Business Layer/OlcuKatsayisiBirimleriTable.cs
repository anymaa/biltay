// This is a "safe" class, meaning that it is created once 
// and never overwritten. Any custom code you add to this class 
// will be preserved when you regenerate your application.
//
// Typical customizations that may be done in this class include
//  - adding custom event handlers
//  - overriding base class methods

using System;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// Provides access to the schema information and record data of a database table (or view).
/// See <see cref="BaseOlcuKatsayisiBirimleriTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseOlcuKatsayisiBirimleriTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseOlcuKatsayisiBirimleriTable"></seealso>
/// <seealso cref="BaseOlcuKatsayisiBirimleriSqlTable"></seealso>
/// <seealso cref="OlcuKatsayisiBirimleriSqlTable"></seealso>
/// <seealso cref="OlcuKatsayisiBirimleriDefinition"></seealso>
/// <seealso cref="OlcuKatsayisiBirimleriRecord"></seealso>
/// <seealso cref="BaseOlcuKatsayisiBirimleriRecord"></seealso>
[SerializableAttribute()]
public class OlcuKatsayisiBirimleriTable : BaseOlcuKatsayisiBirimleriTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="OlcuKatsayisiBirimleriTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="OlcuKatsayisiBirimleriTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="OlcuKatsayisiBirimleriTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(OlcuKatsayisiBirimleriTable_SerializationHelper)); //No other values need to be added
    }

#region "Class OlcuKatsayisiBirimleriTable_SerializationHelper"

    [SerializableAttribute()]
    private class OlcuKatsayisiBirimleriTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return OlcuKatsayisiBirimleriTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="OlcuKatsayisiBirimleriTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="OlcuKatsayisiBirimleriTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static OlcuKatsayisiBirimleriTable Instance = new OlcuKatsayisiBirimleriTable();

    private OlcuKatsayisiBirimleriTable()
    {
    }


} // End class OlcuKatsayisiBirimleriTable

}
