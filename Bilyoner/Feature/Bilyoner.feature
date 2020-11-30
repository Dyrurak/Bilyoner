Feature: Bilyoner
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
* 'Chrome' driver ile browser acilir
Scenario: BilyonerKuponKontrolu
	* Bilyoner sitesine gidilir
	* Giris yap butonuna tiklanir
	* TC Kimlik numarasi alanina '12345678912' girilir
	* Sifre alanina 'password' girilir
	* Giris yap butonuna tiklanarak kullanici girisi yapilir
	* Futbol basligina tiklanir
	* Ustten ilk '3' maca bahis yapilir
	* Bahis Kuponuna tiklanir
	* Bahis kuponunda kaydet butonuna tiklanir
	* Kuponlarım secenegine tiklanir	
	* Bahis yapilan maclar ile kupondaki maclarin ayni oldugu gorulur
	* Kupon silinir