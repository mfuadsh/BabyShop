-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.29-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for babyshop
DROP DATABASE IF EXISTS `babyshop`;
CREATE DATABASE IF NOT EXISTS `babyshop` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `babyshop`;


-- Dumping structure for table babyshop.tb_barang
DROP TABLE IF EXISTS `tb_barang`;
CREATE TABLE IF NOT EXISTS `tb_barang` (
  `kode_barang` varchar(50) NOT NULL,
  `nama_barang` varchar(150) DEFAULT NULL,
  `jenis_barang` varchar(150) DEFAULT NULL,
  `harga_barang` int(11) DEFAULT NULL,
  `satuan` varchar(150) DEFAULT NULL,
  `stok` int(11) DEFAULT NULL,
  PRIMARY KEY (`kode_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table babyshop.tb_barang: ~6 rows (approximately)
/*!40000 ALTER TABLE `tb_barang` DISABLE KEYS */;
INSERT INTO `tb_barang` (`kode_barang`, `nama_barang`, `jenis_barang`, `harga_barang`, `satuan`, `stok`) VALUES
	('BRG001', 'Susu Botol', 'Peralatan Bayi', 60000, 'Botol', 100),
	('BRG002', 'atasan cowok', 'Pakain Bayi', 30000, NULL, NULL),
	('BRG003', 'atasasn cewek', 'Pakain Bayi', 30000, NULL, NULL),
	('BRG004', 'setelan cowok', 'Pakain Bayi', 40000, NULL, NULL),
	('BRG005', 'setelan cewek', 'Pakain Bayi', 54000, NULL, NULL),
	('BRG006', 'terusan', 'Pakain Bayi', 25000, NULL, NULL),
	('BRG007', 'bawahan', 'Pakain Bayi', 15000, NULL, NULL),
	('BRG008', 'jaket', 'Pakain Bayi', 30000, NULL, NULL),
	('BRG009', 'hanshop', NULL, 20000, NULL, NULL),
	('BRG010', 'baby doll', 'Mainan', 10000, NULL, NULL),
	('BRG011', 'topi bayi', 'Aksesoris Bayi', NULL, NULL, NULL),
	('BRG012', 'tas bayi', 'Aksesoris Bayi', NULL, NULL, NULL),
	('BRG013', 'kaos dalam baby', 'Pakain Bayi', NULL, NULL, NULL),
	('BRG014', 'kaos kaki', NULL, NULL, NULL, NULL),
	('BRG015', 'kaos tangan', NULL, NULL, NULL, NULL),
	('BRG016', 'popok selimut', NULL, NULL, NULL, NULL),
	('BRG017', 'popok tali', NULL, NULL, NULL, NULL),
	('BRG018', 'grito/grito ibu', NULL, NULL, NULL, NULL),
	('BRG019', 'celemek / sleber', NULL, NULL, NULL, NULL),
	('BRG020', 'bedong', NULL, NULL, NULL, NULL),
	('BRG021', 'gendong', NULL, NULL, NULL, NULL);
/*!40000 ALTER TABLE `tb_barang` ENABLE KEYS */;


-- Dumping structure for table babyshop.tb_detail_penjualan
DROP TABLE IF EXISTS `tb_detail_penjualan`;
CREATE TABLE IF NOT EXISTS `tb_detail_penjualan` (
  `nota` varchar(25) DEFAULT NULL,
  `kode_barang` varchar(25) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table babyshop.tb_detail_penjualan: ~0 rows (approximately)
/*!40000 ALTER TABLE `tb_detail_penjualan` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_detail_penjualan` ENABLE KEYS */;


-- Dumping structure for table babyshop.tb_kasir
DROP TABLE IF EXISTS `tb_kasir`;
CREATE TABLE IF NOT EXISTS `tb_kasir` (
  `kode_kasir` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `passwd` varchar(100) DEFAULT NULL,
  `nama_lengkap` varchar(100) DEFAULT NULL,
  `jenis_kelamin` varchar(50) DEFAULT NULL,
  `nomor_hp` int(11) DEFAULT NULL,
  `alamat` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`kode_kasir`)
) ENGINE=InnoDB AUTO_INCREMENT=231423424 DEFAULT CHARSET=utf8;

-- Dumping data for table babyshop.tb_kasir: ~0 rows (approximately)
/*!40000 ALTER TABLE `tb_kasir` DISABLE KEYS */;
INSERT INTO `tb_kasir` (`kode_kasir`, `username`, `passwd`, `nama_lengkap`, `jenis_kelamin`, `nomor_hp`, `alamat`) VALUES
	(231423423, 'admin', '*4ACFE3202A5FF5CF467898FC58AAB1D615029441', 'Mimin', 'Perempuan', 8923758, 'jl. Thamrin 35A');
/*!40000 ALTER TABLE `tb_kasir` ENABLE KEYS */;


-- Dumping structure for table babyshop.tb_member
DROP TABLE IF EXISTS `tb_member`;
CREATE TABLE IF NOT EXISTS `tb_member` (
  `id_member` int(11) NOT NULL AUTO_INCREMENT,
  `nama_member` varchar(100) DEFAULT NULL,
  `alamat_member` varchar(200) DEFAULT NULL,
  `nomor_hp` varchar(15) DEFAULT NULL,
  `jenis_kelamin` varchar(15) DEFAULT NULL,
  `foto` mediumtext,
  PRIMARY KEY (`id_member`)
) ENGINE=InnoDB AUTO_INCREMENT=342343 DEFAULT CHARSET=utf8;

-- Dumping data for table babyshop.tb_member: ~0 rows (approximately)
/*!40000 ALTER TABLE `tb_member` DISABLE KEYS */;
INSERT INTO `tb_member` (`id_member`, `nama_member`, `alamat_member`, `nomor_hp`, `jenis_kelamin`, `foto`) VALUES
	(7897, 'Fuad Sholicul', 'Dolopo', NULL, NULL, NULL),
	(342342, 'Danang dan Istri', 'Dolopo', '083432345', 'Laki-laki', NULL);
/*!40000 ALTER TABLE `tb_member` ENABLE KEYS */;


-- Dumping structure for table babyshop.tb_penjualan
DROP TABLE IF EXISTS `tb_penjualan`;
CREATE TABLE IF NOT EXISTS `tb_penjualan` (
  `nota` time NOT NULL,
  `tanggal` date DEFAULT NULL,
  `kasir` varchar(100) DEFAULT NULL,
  `pelanggan` varchar(100) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `disc` int(11) DEFAULT NULL,
  `bayar` int(11) DEFAULT NULL,
  PRIMARY KEY (`nota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table babyshop.tb_penjualan: ~0 rows (approximately)
/*!40000 ALTER TABLE `tb_penjualan` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_penjualan` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
