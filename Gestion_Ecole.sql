create database Gestion_Ecole

use Gestion_Ecole

create table Filiere(
ID_filiere int,
Nom_filiere varchar(20),
PRIMARY KEY (ID_filiere))

create table Matiere(
ID_matiere int,
Nom_matiere varchar(20),
PRIMARY KEY (ID_matiere))

create table Grp_etudiant(
ID_groupe int,
ID_filiere int,
Nbr_etudiant int,
PRIMARY KEY (ID_groupe),
FOREIGN KEY (ID_filiere) REFERENCES Filiere(ID_filiere))

create table Etudiant(
ID_etudiant int,
ID_groupe int,
Prenom varchar(20),
Nom varchar(20),
Date_naissance date,
PRIMARY KEY (ID_etudiant),
FOREIGN KEY (ID_groupe) REFERENCES Grp_etudiant(ID_groupe))

create table Grp_etudie_matiere(
ID_groupe int,
ID_matiere int,
CONSTRAINT Groupe_matiere PRIMARY KEY (ID_groupe,ID_matiere),
FOREIGN KEY (ID_groupe) REFERENCES Grp_etudiant(ID_groupe),
FOREIGN KEY (ID_matiere) REFERENCES Matiere(ID_matiere))

create table Filiere_contient_matiere(
ID_filiere int,
ID_matiere int,
CONSTRAINT filiere_matiere PRIMARY KEY (ID_filiere,ID_matiere),
FOREIGN KEY (ID_filiere) REFERENCES Filiere(ID_filiere),
FOREIGN KEY (ID_matiere) REFERENCES Matiere(ID_matiere))

create table Authentication(
Username varchar(20),
First_Name varchar(20),
Last_Name varchar(20),
Password varchar(20),
User_Type varchar(20),
PRIMARY KEY (Username))