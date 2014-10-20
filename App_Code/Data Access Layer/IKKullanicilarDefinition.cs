using System;

namespace KumePortali.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="IKKullanicilarTable">KumePortali.IKKullanicilarTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="IKKullanicilarTable"></seealso>
public class IKKullanicilarDefinition
{
#region "Definition (XML) for IKKullanicilarDefinition table"
	//Next 474 lines contain Table Definition (XML) for table "IKKullanicilarDefinition"
	private static string _DefinitionString = 
@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""5.2"" Type=""GENERIC"">" +
  @"<ColumnDefinition>" +
    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">" +
      @"<columnName>KullaniciID</columnName>" +
      @"<columnUIName>Kullanici ID</columnUIName>" +
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
      @"<columnName>Adi</columnName>" +
      @"<columnUIName Source=""User"">Adı</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>nvarchar</columnDBType>" +
      @"<columnLengthSet>25</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>1</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">" +
      @"<columnName>Soyadi</columnName>" +
      @"<columnUIName Source=""User"">Soyadı</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>nvarchar</columnDBType>" +
      @"<columnLengthSet>25</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>2</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">" +
      @"<columnName>Eposta</columnName>" +
      @"<columnUIName Source=""User"">e-Posta</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>nvarchar</columnDBType>" +
      @"<columnLengthSet>80</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>3</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">" +
      @"<columnName>GSM</columnName>" +
      @"<columnUIName Source=""User"">GSM</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>nvarchar</columnDBType>" +
      @"<columnLengthSet>22</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>4</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">" +
      @"<columnName>FirmaID</columnName>" +
      @"<columnUIName Source=""User"">Firma Adı</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<foreignKey>" +
        @"<columnFKName>FK_IKKullanicilar_Firma</columnFKName>" +
        @"<columnFKTable>KumePortali.Business.MIYSAHesaplarTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>MusteriIliskileriYonetimi</columnFKOwner>" +
        @"<columnFKColumn>HesapID</columnFKColumn>" +
        @"<columnFKColumnDisplay>FirmaAdi</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>5</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""6"" Priority=""7"" ColumnNum=""6"">" +
      @"<columnName>UnvanID</columnName>" +
      @"<columnUIName Source=""User"">Unvanı</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<foreignKey>" +
        @"<columnFKName>FK_IKKullanicilar_IKUnvanlar</columnFKName>" +
        @"<columnFKTable>KumePortali.Business.IKUnvanlarTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>SistemAyarlari</columnFKOwner>" +
        @"<columnFKColumn>UnvanID</columnFKColumn>" +
        @"<columnFKColumnDisplay>UnvanAdi</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>6</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""7"" Priority=""8"" ColumnNum=""7"">" +
      @"<columnName>YetkiTurID</columnName>" +
      @"<columnUIName Source=""User"">Yetki T&#252;r&#252;</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>7</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""8"" Priority=""9"" ColumnNum=""8"">" +
      @"<columnName>HesapID</columnName>" +
      @"<columnUIName>Hesap ID</columnUIName>" +
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
    @"<Column InternalName=""9"" Priority=""10"" ColumnNum=""9"">" +
      @"<columnName>TCKimlikNo</columnName>" +
      @"<columnUIName>TC Kimlik No</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>nvarchar</columnDBType>" +
      @"<columnLengthSet>11</columnLengthSet>" +
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
    @"<Column InternalName=""10"" Priority=""11"" ColumnNum=""10"">" +
      @"<columnName>IsTelefonu</columnName>" +
      @"<columnUIName Source=""User"">İş Telefonu</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>nvarchar</columnDBType>" +
      @"<columnLengthSet>22</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>10</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""11"" Priority=""12"" ColumnNum=""11"">" +
      @"<columnName>KullaniciAdi</columnName>" +
      @"<columnUIName>Kullanici Adi</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>nvarchar</columnDBType>" +
      @"<columnLengthSet>80</columnLengthSet>" +
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
    @"<Column InternalName=""12"" Priority=""13"" ColumnNum=""12"">" +
      @"<columnName>Sifre</columnName>" +
      @"<columnUIName>Sifre</columnUIName>" +
      @"<columnType>Binary</columnType>" +
      @"<columnDBType>varbinary</columnDBType>" +
      @"<columnLengthSet>16</columnLengthSet>" +
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
    @"<Column InternalName=""13"" Priority=""14"" ColumnNum=""13"">" +
      @"<columnName>OlusturmaTarihi</columnName>" +
      @"<columnUIName Source=""User"">Oluşturma Tarihi</columnUIName>" +
      @"<columnType>Date</columnType>" +
      @"<columnDBType>smalldatetime</columnDBType>" +
      @"<columnLengthSet></columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>13</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""14"" Priority=""15"" ColumnNum=""14"">" +
      @"<columnName>OlusturanID</columnName>" +
      @"<columnUIName Source=""User"">Oluşturan</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault Source=""User""></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed Source=""User"">N</columnComputed>" +
      @"<columnIdentity Source=""User"">N</columnIdentity>" +
      @"<columnReadOnly Source=""User"">N</columnReadOnly>" +
      @"<columnRequired>N</columnRequired>" +
      @"<columnNotNull>N</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<foreignKey>" +
        @"<columnFKName>FK_IKKullanicilar_IKKullanicilar</columnFKName>" +
        @"<columnFKTable>KumePortali.Business.IKKullanicilarTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>SistemAyarlari</columnFKOwner>" +
        @"<columnFKColumn>KullaniciID</columnFKColumn>" +
        @"<columnFKColumnDisplay>Adi</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
      @"<columnCodeName></columnCodeName>" +
      @"<InternalName>14</InternalName>" +
      @"<columnTableClassName></columnTableClassName>" +
    "</Column>" +
    @"<Column InternalName=""15"" Priority=""16"" ColumnNum=""15"">" +
      @"<columnName>DuzenlenmeTarihi</columnName>" +
      @"<columnUIName>Duzenlenme Tarihi</columnUIName>" +
      @"<columnType>Date</columnType>" +
      @"<columnDBType>smalldatetime</columnDBType>" +
      @"<columnLengthSet></columnLengthSet>" +
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
    "</Column>" +
    @"<Column InternalName=""16"" Priority=""17"" ColumnNum=""16"">" +
      @"<columnName>DuzenleyenID</columnName>" +
      @"<columnUIName>Duzenleyen ID</columnUIName>" +
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
        @"<columnFKName>FK_IKKullanicilar_IKKullanicilar1</columnFKName>" +
        @"<columnFKTable>KumePortali.Business.IKKullanicilarTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>SistemAyarlari</columnFKOwner>" +
        @"<columnFKColumn>KullaniciID</columnFKColumn>" +
        @"<columnFKColumnDisplay>Adi</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
    "</Column>" +
    @"<Column InternalName=""17"" Priority=""18"" ColumnNum=""17"">" +
      @"<columnName>AktifPasif</columnName>" +
      @"<columnUIName>Aktif Pasif</columnUIName>" +
      @"<columnType>Boolean</columnType>" +
      @"<columnDBType>bit</columnDBType>" +
      @"<columnLengthSet></columnLengthSet>" +
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
  @"<TableName>IKKullanicilar</TableName>" +
  @"<Version></Version>" +
  @"<Owner>SistemAyarlari</Owner>" +
  @"<TableCodeName>IKKullanicilar</TableCodeName>" +
  @"<TableAliasName>IKKullanicilar_</TableAliasName>" +
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
	/// <see cref="IKKullanicilarTable"></see>
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
