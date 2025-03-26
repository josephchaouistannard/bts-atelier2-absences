-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 25 mars 2025 à 09:12
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(2, '2024-06-25 10:33:15', '2025-12-15 00:40:45', 3),
(10, '2025-02-09 06:00:42', '2025-01-24 21:17:42', 3),
(19, '2024-05-27 17:42:13', '2024-12-04 15:18:55', 2),
(6, '2026-02-25 19:52:33', '2025-01-25 11:51:57', 3),
(16, '2025-03-15 16:47:35', '2025-12-24 23:01:17', 3),
(12, '2025-04-24 14:23:31', '2024-11-03 20:04:34', 2),
(6, '2025-01-12 20:27:13', '2024-04-17 03:15:34', 3),
(13, '2025-12-28 20:09:04', '2028-09-01 17:24:15', 1),
(7, '2025-09-11 21:54:46', '2025-04-06 22:10:21', 3),
(5, '2024-03-22 22:40:34', '2026-01-08 22:33:13', 3),
(8, '2025-11-16 01:04:04', '2025-03-16 20:36:21', 3),
(14, '2025-08-20 05:00:30', '2024-06-16 21:20:17', 3),
(6, '2026-02-13 02:38:32', '2024-08-03 17:36:49', 3),
(2, '2025-08-23 09:07:54', '2024-11-13 21:56:56', 1),
(9, '2024-07-16 05:37:56', '2026-01-25 23:16:42', 1),
(9, '2025-02-13 12:03:18', '2024-05-28 18:58:01', 2),
(10, '2024-08-17 04:16:44', '2025-02-03 15:38:01', 4),
(3, '2025-06-30 05:08:05', '2025-05-30 08:16:44', 2),
(17, '2025-02-08 04:53:59', '2025-02-22 04:55:22', 3),
(5, '2025-08-09 13:18:41', '2024-03-31 04:58:41', 4),
(2, '2024-05-13 23:54:26', '2025-05-24 15:43:23', 1),
(4, '2024-11-17 12:57:43', '2024-05-09 00:24:12', 3),
(8, '2025-01-09 13:08:33', '2025-12-03 02:32:55', 2),
(17, '2026-02-05 01:17:39', '2026-02-24 17:34:26', 3),
(14, '2024-04-06 12:12:02', '2025-04-15 02:43:03', 3),
(18, '2025-06-01 15:32:42', '2025-02-27 10:19:08', 2),
(5, '2025-08-31 20:09:44', '2025-09-28 07:58:04', 3),
(17, '2024-12-13 18:06:27', '2024-12-15 00:54:29', 1),
(3, '2025-04-20 00:36:01', '2025-07-16 14:58:38', 3),
(8, '2026-01-26 01:00:11', '2024-05-02 02:32:45', 3),
(7, '2024-12-20 02:14:48', '2025-02-18 13:38:33', 4),
(12, '2024-10-16 11:26:43', '2025-06-03 21:08:01', 3),
(19, '2025-12-14 10:43:16', '2025-03-04 00:15:14', 2),
(17, '2025-10-29 03:59:54', '2024-04-03 10:35:41', 4),
(19, '2024-12-28 18:50:16', '2025-08-05 22:46:26', 1),
(11, '2025-03-23 09:24:24', '2025-03-29 09:24:23', 1),
(13, '2024-09-20 23:00:13', '2025-10-03 01:38:50', 2),
(4, '2025-10-28 15:42:44', '2024-06-14 12:46:59', 2),
(3, '2026-02-24 12:29:23', '2024-10-03 15:05:49', 3),
(4, '2025-04-27 06:54:59', '2025-06-22 09:48:35', 2),
(17, '2024-05-06 01:00:43', '2025-03-17 01:53:05', 2),
(16, '2024-06-05 13:36:38', '2025-11-09 16:26:38', 1),
(15, '2025-01-26 15:23:47', '2024-09-03 17:33:27', 2),
(19, '2025-03-05 04:39:51', '2025-11-21 03:53:14', 2),
(6, '2024-10-11 05:35:49', '2024-11-06 17:02:14', 3),
(10, '2024-05-23 05:00:37', '2024-08-24 02:07:55', 4),
(20, '2024-09-22 04:48:38', '2024-12-08 04:49:09', 3),
(9, '2025-05-12 06:35:28', '2025-07-02 09:26:36', 2),
(2, '2026-02-02 22:10:15', '2024-11-13 20:57:16', 4),
(3, '2025-03-21 22:03:12', '2024-05-29 17:23:14', 3),
(13, '2025-03-24 19:07:38', '2025-03-30 19:07:38', 4),
(13, '2024-08-21 20:53:31', '2024-08-22 20:53:31', 1),
(11, '2025-03-25 09:24:24', '2025-03-29 09:24:23', 1),
(13, '2023-03-23 20:55:49', '2023-03-24 20:55:49', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Jordan', 'Hashim', '09 31 33 29 79', 'eget.massa.suspendisse@yahoo.edu', 1),
(2, 'Richard', 'Axel', '05 76 06 65 11', 'non.bibendum@hotmail.com', 2),
(3, 'Hahn', 'Burke', '04 46 86 64 26', 'tellus@google.ca', 2),
(4, 'Holmes', 'Delilah', '09 76 98 53 13', 'urna@outlook.net', 2),
(5, 'Winters', 'Rigel', '08 74 28 69 76', 'fermentum.fermentum.arcu@aol.com', 1),
(6, 'Rodriguez', 'Mechelle', '05 87 81 65 66', 'imperdiet.erat.nonummy@google.couk', 1),
(7, 'Munoz', 'Winter', '02 13 43 74 89', 'nunc.pulvinar@google.net', 3),
(8, 'Frederick', 'Nerea', '02 15 95 73 50', 'luctus@icloud.ca', 1),
(9, 'Reed', 'Declan', '06 74 27 26 28', 'molestie.tortor@yahoo.net', 3),
(10, 'Prince', 'Joel', '07 25 87 94 59', 'purus.duis.elementum@yahoo.com', 1),
(11, 'Fleming', 'Adrienne', '01 01 85 61 25', 'sed.hendrerit.a@yahoo.ca', 3),
(12, 'Merrill', 'Audra', '09 42 34 76 10', 'donec.tincidunt@yahoo.org', 2),
(13, 'Barnes', 'Nicholas', '08 54 95 62 27', 'enim.condimentum@icloud.couk', 1),
(14, 'Johnson', 'Mary', '05 20 63 53 43', 'primis.in@icloud.edu', 2),
(15, 'Webster', 'Claudia', '03 29 48 37 40', 'donec@outlook.org', 3),
(16, 'Noble', 'Adrienne', '05 66 34 95 31', 'dis.parturient@outlook.com', 2),
(17, 'Blackwell', 'Melvin', '06 18 50 82 11', 'magna.phasellus@google.edu', 2),
(18, 'Chavez', 'MacKenzie', '06 83 48 81 57', 'vitae@outlook.org', 3),
(19, 'Floyd', 'Lillith', '07 76 60 88 76', 'malesuada.vel.convallis@icloud.couk', 3),
(20, 'Larsen', 'Bradley', '04 84 69 64 25', 'ut@outlook.com', 3),
(25, 'tester', 'test', 'test', 'test', 2);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('responsable', 'f1d6349e79e0c810b8d0221ac8ba384f3d9caadeb279d2022004142ccdff8058');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
