﻿using System;

namespace KumePortali.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="PYeteneklerTable">KumePortali.PYeteneklerTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="PYeteneklerTable"></seealso>
public class PYeteneklerDefinition
{
#region "Definition (XML) for PYeteneklerDefinition table"
	//Next 112 lines contain Table Definition (XML) for table "PYeteneklerDefinition"
	private static string _DefinitionString = 
@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""5.2"" Type=""GENERIC"">" +
  @"<ColumnDefinition>" +
    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">" +
      @"<columnName>YetenekID</columnName>" +
      @"<columnUIName>Yetenek ID</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>Y</columnIndex>" +
      @"<columnUnique>Y</columnUnique>" +
      @"<columnFunction>notrim</columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>Y</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed>Y</columnComputed>" +
      @"<columnIdentity>Y</columnIdentity>" +
      @"<columnReadOnly>Y</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>Y</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
    "</Column>" +
    @"<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">" +
      @"<columnName>YeteneginAdi</columnName>" +
      @"<columnUIName>Yetenegin Adi</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>nvarchar</columnDBType>" +
      @"<columnLengthSet>100</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed>N</columnComputed>" +
      @"<columnIdentity>N</columnIdentity>" +
      @"<columnReadOnly>N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
    "</Column>" +
    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">" +
      @"<columnName>YetenekTurID</columnName>" +
      @"<columnUIName>Yetenek Tur ID</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction>notrim</columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed>N</columnComputed>" +
      @"<columnIdentity>N</columnIdentity>" +
      @"<columnReadOnly>N</columnReadOnly>" +
      @"<columnRequired>Y</columnRequired>" +
      @"<columnNotNull>Y</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<foreignKey>" +
        @"<columnFKName>FK_PYetenekler_PYetenekTurleri</columnFKName>" +
        @"<columnFKTable>KumePortali.Business.PYetenekTurleriTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>SistemAyarlari</columnFKOwner>" +
        @"<columnFKColumn>YetenekTurID</columnFKColumn>" +
        @"<columnFKColumnDisplay>YeteneginTuru</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
    "</Column>" +
    @"<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">" +
      @"<columnName>Aciklama</columnName>" +
      @"<columnUIName>Aciklama</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>nvarchar</columnDBType>" +
      @"<columnLengthSet>100</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed>N</columnComputed>" +
      @"<columnIdentity>N</columnIdentity>" +
      @"<columnReadOnly>N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
    "</Column>" +
  "</ColumnDefinition>" +
  @"<TableName>PYetenekler</TableName>" +
  @"<Version></Version>" +
  @"<Owner>SistemAyarlari</Owner>" +
  @"<TableCodeName>PYetenekler</TableCodeName>" +
  @"<TableAliasName>PYetenekler_</TableAliasName>" +
  @"<ConnectionName>DatabaseEsac1</ConnectionName>" +
  @"<canCreateRecords Source=""Database"">Y</canCreateRecords>" +
  @"<canEditRecords Source=""Database"">Y</canEditRecords>" +
  @"<canDeleteRecords Source=""Database"">Y</canDeleteRecords>" +
  @"<canViewRecords Source=""Database"">Y</canViewRecords>" +
  @"<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>" +
  @"<AppShortName>KumePortali</AppShortName>" +
"</XMLDefinition>";
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="PYeteneklerTable"></see>
	/// class's TableDefinition.
	/// </summary>
	/// <remarks>This function is only called once at runtime.</remarks>
	/// <returns>An XML string.</returns>
	public static string GetXMLString()
	{
		return _DefinitionString;
	}
}

}
