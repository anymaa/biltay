﻿using System;

namespace KumePortali.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="KatilimciListesiTable">KumePortali.KatilimciListesiTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="KatilimciListesiTable"></seealso>
public class KatilimciListesiDefinition
{
#region "Definition (XML) for KatilimciListesiDefinition table"
	//Next 244 lines contain Table Definition (XML) for table "KatilimciListesiDefinition"
	private static string _DefinitionString = 
@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""5.2"" Type=""GENERIC"">" +
  @"<ColumnDefinition>" +
    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">" +
      @"<columnName>KatilimciID</columnName>" +
      @"<columnUIName>Katilimci ID</columnUIName>" +
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
      @"<columnName>EtkinlikID</columnName>" +
      @"<columnUIName>Etkinlik ID</columnUIName>" +
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
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<foreignKey>" +
        @"<columnFKName>FK_KatilimciListesi_Etkinlikler</columnFKName>" +
        @"<columnFKTable>KumePortali.Business.EtkinliklerTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>IcHaberlesme</columnFKOwner>" +
        @"<columnFKColumn>EtkinlikID</columnFKColumn>" +
        @"<columnFKColumnDisplay>Konu</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
    "</Column>" +
    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">" +
      @"<columnName>KullaniciID</columnName>" +
      @"<columnUIName>Kullanici ID</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
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
    @"<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">" +
      @"<columnName>EgitiminKalitesi</columnName>" +
      @"<columnUIName>Egitimin Kalitesi</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>tinyint</columnDBType>" +
      @"<columnLengthSet>3.0</columnLengthSet>" +
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
    @"<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">" +
      @"<columnName>EgitiminKonusu</columnName>" +
      @"<columnUIName>Egitimin Konusu</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>tinyint</columnDBType>" +
      @"<columnLengthSet>3.0</columnLengthSet>" +
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
    @"<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">" +
      @"<columnName>EgitimSuresi</columnName>" +
      @"<columnUIName>Egitim Suresi</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>tinyint</columnDBType>" +
      @"<columnLengthSet>3.0</columnLengthSet>" +
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
    @"<Column InternalName=""6"" Priority=""7"" ColumnNum=""6"">" +
      @"<columnName>EgitimZamani</columnName>" +
      @"<columnUIName>Egitim Zamani</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>tinyint</columnDBType>" +
      @"<columnLengthSet>3.0</columnLengthSet>" +
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
    @"<Column InternalName=""7"" Priority=""8"" ColumnNum=""7"">" +
      @"<columnName>EgitimOrtam</columnName>" +
      @"<columnUIName>Egitim Ortam</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>tinyint</columnDBType>" +
      @"<columnLengthSet>3.0</columnLengthSet>" +
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
    @"<Column InternalName=""8"" Priority=""9"" ColumnNum=""8"">" +
      @"<columnName>EgitiminIseKatkisi</columnName>" +
      @"<columnUIName>Egitimin Ise Katkisi</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>tinyint</columnDBType>" +
      @"<columnLengthSet>3.0</columnLengthSet>" +
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
    @"<Column InternalName=""9"" Priority=""10"" ColumnNum=""9"">" +
      @"<columnName>EgitiminKisiyeKatkisi</columnName>" +
      @"<columnUIName>Egitimin Kisiye Katkisi</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>tinyint</columnDBType>" +
      @"<columnLengthSet>3.0</columnLengthSet>" +
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
  @"<TableName>KatilimciListesi</TableName>" +
  @"<Version></Version>" +
  @"<Owner>IcHaberlesme</Owner>" +
  @"<TableCodeName>KatilimciListesi</TableCodeName>" +
  @"<TableAliasName>KatilimciListesi_</TableAliasName>" +
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
	/// <see cref="KatilimciListesiTable"></see>
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
