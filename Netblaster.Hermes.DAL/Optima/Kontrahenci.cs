//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Netblaster.Hermes.DAL.Optima
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kontrahenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kontrahenci()
        {
            this.Kontrahenci1 = new HashSet<Kontrahenci>();
        }
    
        public int Knt_KntId { get; set; }
        public Nullable<short> Knt_PodmiotTyp { get; set; }
        public string Knt_Kod { get; set; }
        public string Knt_GLN { get; set; }
        public string Knt_EAN { get; set; }
        public string Knt_Grupa { get; set; }
        public string Knt_Nazwa1 { get; set; }
        public string Knt_Nazwa2 { get; set; }
        public string Knt_Nazwa3 { get; set; }
        public string Knt_Kraj { get; set; }
        public string Knt_Wojewodztwo { get; set; }
        public string Knt_Powiat { get; set; }
        public string Knt_Gmina { get; set; }
        public string Knt_Ulica { get; set; }
        public string Knt_NrDomu { get; set; }
        public string Knt_NrLokalu { get; set; }
        public string Knt_Miasto { get; set; }
        public string Knt_KodPocztowy { get; set; }
        public string Knt_Poczta { get; set; }
        public string Knt_Adres2 { get; set; }
        public string Knt_NipKraj { get; set; }
        public string Knt_NipE { get; set; }
        public string Knt_Nip { get; set; }
        public string Knt_Regon { get; set; }
        public string Knt_Pesel { get; set; }
        public string Knt_Telefon1 { get; set; }
        public string Knt_Telefon2 { get; set; }
        public string Knt_TelefonSms { get; set; }
        public string Knt_Fax { get; set; }
        public string Knt_Email { get; set; }
        public string Knt_URL { get; set; }
        public string Knt_KrajISO { get; set; }
        public string Knt_Zezwolenie { get; set; }
        public string Knt_KodTransakcji { get; set; }
        public Nullable<System.Guid> Knt_BazaBR_GUID { get; set; }
        public Nullable<int> Knt_BNaID { get; set; }
        public string Knt_RachunekNr { get; set; }
        public short Knt_IBAN { get; set; }
        public string Knt_RachunekNr0 { get; set; }
        public string Knt_OsTytul { get; set; }
        public byte Knt_OsPlec { get; set; }
        public string Knt_OsNazwisko { get; set; }
        public string Knt_OsKraj { get; set; }
        public string Knt_OsWojewodztwo { get; set; }
        public string Knt_OsPowiat { get; set; }
        public string Knt_OsGmina { get; set; }
        public string Knt_OsUlica { get; set; }
        public string Knt_OsNrDomu { get; set; }
        public string Knt_OsNrLokalu { get; set; }
        public string Knt_OsMiasto { get; set; }
        public string Knt_OsKodPocztowy { get; set; }
        public string Knt_OsPoczta { get; set; }
        public string Knt_OsAdres2 { get; set; }
        public string Knt_OsTelefon { get; set; }
        public string Knt_OsGSM { get; set; }
        public string Knt_OsEmail { get; set; }
        public byte Knt_Informacje { get; set; }
        public decimal Knt_Upust { get; set; }
        public byte Knt_LimitFlag { get; set; }
        public decimal Knt_LimitKredytu { get; set; }
        public byte Knt_LimitPrzeterKredytFlag { get; set; }
        public decimal Knt_LimitPrzeterKredytWartosc { get; set; }
        public short Knt_Ceny { get; set; }
        public Nullable<int> Knt_FplID { get; set; }
        public short Knt_MaxZwloka { get; set; }
        public byte Knt_TerminPlat { get; set; }
        public short Knt_Termin { get; set; }
        public string Knt_KontoOdb { get; set; }
        public string Knt_KontoDost { get; set; }
        public Nullable<int> Knt_KatID { get; set; }
        public Nullable<int> Knt_KatZakID { get; set; }
        public byte Knt_BlokadaDok { get; set; }
        public string Knt_LimitKredytuWal { get; set; }
        public decimal Knt_LimitKredytuWykorzystany { get; set; }
        public byte Knt_NieRozliczac { get; set; }
        public byte Knt_PodatekVat { get; set; }
        public byte Knt_Finalny { get; set; }
        public byte Knt_FinalnyWegiel { get; set; }
        public byte Knt_Export { get; set; }
        public byte Knt_Rodzaj { get; set; }
        public byte Knt_Rodzaj_Dostawca { get; set; }
        public byte Knt_Rodzaj_Odbiorca { get; set; }
        public byte Knt_Rodzaj_Konkurencja { get; set; }
        public byte Knt_Rodzaj_Partner { get; set; }
        public byte Knt_Rodzaj_Potencjalny { get; set; }
        public byte Knt_Medialny { get; set; }
        public byte Knt_MalyPod { get; set; }
        public byte Knt_Rolnik { get; set; }
        public byte Knt_Nieaktywny { get; set; }
        public byte Knt_Chroniony { get; set; }
        public string Knt_Opis { get; set; }
        public Nullable<int> Knt_OdbiorcaId { get; set; }
        public Nullable<short> Knt_OpiekunTyp { get; set; }
        public Nullable<int> Knt_OpiekunId { get; set; }
        public Nullable<short> Knt_OpiekunKsiegTyp { get; set; }
        public Nullable<int> Knt_OpiekunKsiegID { get; set; }
        public Nullable<byte> Knt_OpiekunKsiegDomyslny { get; set; }
        public Nullable<short> Knt_OpiekunPiKTyp { get; set; }
        public Nullable<int> Knt_OpiekunPiKID { get; set; }
        public Nullable<byte> Knt_OpiekunPiKDomyslny { get; set; }
        public short Knt_TerminZwrotuKaucji { get; set; }
        public byte Knt_NaliczajPlatnosc { get; set; }
        public byte Knt_ZakazDokumentowHaMag { get; set; }
        public byte Knt_ZgodaNaEFaktury { get; set; }
        public Nullable<byte> Knt_TypWymiany { get; set; }
        public byte Knt_PowiazanyUoV { get; set; }
        public byte Knt_MetodaKasowa { get; set; }
        public Nullable<int> Knt_UWDId { get; set; }
        public string Knt_UWDOddzial { get; set; }
        public string Knt_UWDEmail { get; set; }
        public Nullable<System.DateTime> Knt_TS_Export { get; set; }
        public string Knt_ImportAppId { get; set; }
        public string Knt_ImportRowId { get; set; }
        public Nullable<int> Knt_OpeZalID { get; set; }
        public Nullable<int> Knt_StaZalId { get; set; }
        public System.DateTime Knt_TS_Zal { get; set; }
        public Nullable<int> Knt_OpeModID { get; set; }
        public Nullable<int> Knt_StaModId { get; set; }
        public System.DateTime Knt_TS_Mod { get; set; }
        public Nullable<short> Knt_GIDTyp { get; set; }
        public Nullable<int> Knt_GIDFirma { get; set; }
        public Nullable<int> Knt_GIDNumer { get; set; }
        public Nullable<short> Knt_GIDLp { get; set; }
        public Nullable<int> Knt_eSklepID { get; set; }
        public byte Knt_FCzynnosci { get; set; }
        public byte Knt_FCzesci { get; set; }
        public string Knt_KorKraj { get; set; }
        public string Knt_KorMiasto { get; set; }
        public string Knt_KorKodPocztowy { get; set; }
        public string Knt_KorPoczta { get; set; }
        public string Knt_KorUlica { get; set; }
        public string Knt_KorNrDomu { get; set; }
        public string Knt_KorNrLokalu { get; set; }
        public byte Knt_NieNaliczajOdsetek { get; set; }
        public byte Knt_ESklep { get; set; }
        public byte Knt_ZwolnionyZAkcyzy { get; set; }
        public Nullable<int> Knt_WindykacjaSchematId { get; set; }
        public Nullable<int> Knt_WindykacjaOsobaId { get; set; }
        public string Knt_WindykacjaEMail { get; set; }
        public string Knt_WindykacjaTelefonSms { get; set; }
        public byte Knt_Komornik { get; set; }
        public string Knt_KomornikOkreg { get; set; }
        public string Knt_KomornikMiasto { get; set; }
        public string Knt_KomornikRewir { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrahenci> Kontrahenci1 { get; set; }
        public virtual Kontrahenci Kontrahenci2 { get; set; }
    }
}
