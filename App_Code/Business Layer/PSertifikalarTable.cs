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
/// See <see cref="BasePSertifikalarTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BasePSertifikalarTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BasePSertifikalarTable"></seealso>
/// <seealso cref="BasePSertifikalarSqlTable"></seealso>
/// <seealso cref="PSertifikalarSqlTable"></seealso>
/// <seealso cref="PSertifikalarDefinition"></seealso>
/// <seealso cref="PSertifikalarRecord"></seealso>
/// <seealso cref="BasePSertifikalarRecord"></seealso>
[SerializableAttribute()]
public class PSertifikalarTable : BasePSertifikalarTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="PSertifikalarTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="PSertifikalarTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="PSertifikalarTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(PSertifikalarTable_SerializationHelper)); //No other values need to be added
    }

#region "Class PSertifikalarTable_SerializationHelper"

    [SerializableAttribute()]
    private class PSertifikalarTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return PSertifikalarTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="PSertifikalarTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="PSertifikalarTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static PSertifikalarTable Instance = new PSertifikalarTable();

    private PSertifikalarTable()
    {
    }


} // End class PSertifikalarTable

}
