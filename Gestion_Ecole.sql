CREATE DATABASE Gestion_Ecole
GO
USE [Gestion_Ecole]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Authentication](
	[Username] [varchar](20) NOT NULL,
	[First_Name] [varchar](20) NOT NULL,
	[Last_Name] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Type] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Authenti__536C85E5DCA75983] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Etudiant](
	[ID_etudiant] [int] NOT NULL,
	[ID_groupe] [int] NOT NULL,
	[Prenom] [varchar](20) NOT NULL,
	[Nom] [varchar](20) NOT NULL,
	[Date_naissance] [date] NOT NULL,
 CONSTRAINT [PK__Etudiant__D3B6973806B93177] PRIMARY KEY CLUSTERED 
(
	[ID_etudiant] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Filiere](
	[ID_filiere] [int] NOT NULL,
	[Nom_filiere] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Filiere__8D45CCD187557295] PRIMARY KEY CLUSTERED 
(
	[ID_filiere] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Filiere_contient_matiere](
	[ID_filiere] [int] NOT NULL,
	[ID_matiere] [int] NOT NULL,
 CONSTRAINT [filiere_matiere] PRIMARY KEY CLUSTERED 
(
	[ID_filiere] ASC,
	[ID_matiere] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Grp_etudiant](
	[ID_groupe] [int] NOT NULL,
	[ID_filiere] [int] NOT NULL,
	[Nbr_etudiant] [int] NOT NULL,
 CONSTRAINT [PK__Grp_etud__344D0C9F1F4783F1] PRIMARY KEY CLUSTERED 
(
	[ID_groupe] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Grp_etudie_matiere](
	[ID_groupe] [int] NOT NULL,
	[ID_matiere] [int] NOT NULL,
 CONSTRAINT [Groupe_matiere] PRIMARY KEY CLUSTERED 
(
	[ID_groupe] ASC,
	[ID_matiere] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Helper](
	[ID] [varchar](10) NOT NULL,
	[VALUE] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Matiere](
	[ID_matiere] [int] NOT NULL,
	[Nom_matiere] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Matiere__03945CDAACA41BB2] PRIMARY KEY CLUSTERED 
(
	[ID_matiere] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [Authentication] ([Username], [First_Name], [Last_Name], [Password], [Type]) VALUES (N'amine_el_azzouzi', N'Amine', N'EL AZZOUZI', N'ensa1234', N'admin')
GO
ALTER TABLE [Etudiant]  WITH CHECK ADD  CONSTRAINT [FK__Etudiant__ID_gro__2B3F6F97] FOREIGN KEY([ID_groupe])
REFERENCES [Grp_etudiant] ([ID_groupe])
GO
ALTER TABLE [Etudiant] CHECK CONSTRAINT [FK__Etudiant__ID_gro__2B3F6F97]
GO
ALTER TABLE [Filiere_contient_matiere]  WITH CHECK ADD  CONSTRAINT [FK__Filiere_c__ID_fi__31EC6D26] FOREIGN KEY([ID_filiere])
REFERENCES [Filiere] ([ID_filiere])
GO
ALTER TABLE [Filiere_contient_matiere] CHECK CONSTRAINT [FK__Filiere_c__ID_fi__31EC6D26]
GO
ALTER TABLE [Filiere_contient_matiere]  WITH CHECK ADD  CONSTRAINT [FK__Filiere_c__ID_ma__32E0915F] FOREIGN KEY([ID_matiere])
REFERENCES [Matiere] ([ID_matiere])
GO
ALTER TABLE [Filiere_contient_matiere] CHECK CONSTRAINT [FK__Filiere_c__ID_ma__32E0915F]
GO
ALTER TABLE [Grp_etudiant]  WITH CHECK ADD  CONSTRAINT [FK__Grp_etudi__ID_fi__286302EC] FOREIGN KEY([ID_filiere])
REFERENCES [Filiere] ([ID_filiere])
GO
ALTER TABLE [Grp_etudiant] CHECK CONSTRAINT [FK__Grp_etudi__ID_fi__286302EC]
GO
ALTER TABLE [Grp_etudie_matiere]  WITH CHECK ADD  CONSTRAINT [FK__Grp_etudi__ID_gr__2E1BDC42] FOREIGN KEY([ID_groupe])
REFERENCES [Grp_etudiant] ([ID_groupe])
GO
ALTER TABLE [Grp_etudie_matiere] CHECK CONSTRAINT [FK__Grp_etudi__ID_gr__2E1BDC42]
GO
ALTER TABLE [Grp_etudie_matiere]  WITH CHECK ADD  CONSTRAINT [FK__Grp_etudi__ID_ma__2F10007B] FOREIGN KEY([ID_matiere])
REFERENCES [Matiere] ([ID_matiere])
GO
ALTER TABLE [Grp_etudie_matiere] CHECK CONSTRAINT [FK__Grp_etudi__ID_ma__2F10007B]
GO
