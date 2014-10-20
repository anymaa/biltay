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
/// See <see cref="BaseTedarikciDegerlendirmeTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseTedarikciDegerlendirmeTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseTedarikciDegerlendirmeTable"></seealso>
/// <seealso cref="BaseTedarikciDegerlendirmeSqlTable"></seealso>
/// <seealso cref="TedarikciDegerlendirmeSqlTable"></seealso>
/// <seealso cref="TedarikciDegerlendirmeDefinition"></seealso>
/// <seealso cref="TedarikciDegerlendirmeRecord"></seealso>
/// <seealso cref="BaseTedarikciDegerlendirmeRecord"></seealso>
[SerializableAttribute()]
public class TedarikciDegerlendirmeTable : BaseTedarikciDegerlendirmeTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="TedarikciDegerlendirmeTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="TedarikciDegerlendirmeTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="TedarikciDegerlendirmeTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(TedarikciDegerlendirmeTable_SerializationHelper)); //No other values need to be added
    }

#region "Class TedarikciDegerlendirmeTable_SerializationHelper"

    [SerializableAttribute()]
    private class TedarikciDegerlendirmeTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return TedarikciDegerlendirmeTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="TedarikciDegerlendirmeTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="TedarikciDegerlendirmeTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static TedarikciDegerlendirmeTable Instance = new TedarikciDegerlendirmeTable();

    private TedarikciDegerlendirmeTable()
    {
    }


} // End class TedarikciDegerlendirmeTable

}
