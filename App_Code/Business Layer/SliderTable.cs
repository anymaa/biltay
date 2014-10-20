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
/// See <see cref="BaseSliderTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseSliderTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseSliderTable"></seealso>
/// <seealso cref="BaseSliderSqlTable"></seealso>
/// <seealso cref="SliderSqlTable"></seealso>
/// <seealso cref="SliderDefinition"></seealso>
/// <seealso cref="SliderRecord"></seealso>
/// <seealso cref="BaseSliderRecord"></seealso>
[SerializableAttribute()]
public class SliderTable : BaseSliderTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="SliderTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="SliderTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="SliderTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(SliderTable_SerializationHelper)); //No other values need to be added
    }

#region "Class SliderTable_SerializationHelper"

    [SerializableAttribute()]
    private class SliderTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return SliderTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="SliderTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="SliderTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static SliderTable Instance = new SliderTable();

    private SliderTable()
    {
    }


} // End class SliderTable

}
