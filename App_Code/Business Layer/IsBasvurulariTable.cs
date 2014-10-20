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
/// See <see cref="BaseIsBasvurulariTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseIsBasvurulariTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseIsBasvurulariTable"></seealso>
/// <seealso cref="BaseIsBasvurulariSqlTable"></seealso>
/// <seealso cref="IsBasvurulariSqlTable"></seealso>
/// <seealso cref="IsBasvurulariDefinition"></seealso>
/// <seealso cref="IsBasvurulariRecord"></seealso>
/// <seealso cref="BaseIsBasvurulariRecord"></seealso>
[SerializableAttribute()]
public class IsBasvurulariTable : BaseIsBasvurulariTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="IsBasvurulariTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="IsBasvurulariTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="IsBasvurulariTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(IsBasvurulariTable_SerializationHelper)); //No other values need to be added
    }

#region "Class IsBasvurulariTable_SerializationHelper"

    [SerializableAttribute()]
    private class IsBasvurulariTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return IsBasvurulariTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="IsBasvurulariTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="IsBasvurulariTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static IsBasvurulariTable Instance = new IsBasvurulariTable();

    private IsBasvurulariTable()
    {
    }


} // End class IsBasvurulariTable

}
