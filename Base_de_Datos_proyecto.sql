SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `proyecto_final_bd` ;
CREATE SCHEMA IF NOT EXISTS `proyecto_final_bd` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `proyecto_final_bd` ;

-- -----------------------------------------------------
-- Table `proyecto_final_bd`.`ALUMNOS`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyecto_final_bd`.`ALUMNOS` ;

CREATE TABLE IF NOT EXISTS `proyecto_final_bd`.`ALUMNOS` (
  `matricula` VARCHAR(9) NOT NULL,
  `nombre` VARCHAR(50) NULL,
  `apellidoP` VARCHAR(50) NULL,
  `apellidoM` VARCHAR(50) NULL,
  `semestre` TINYINT NULL,
  `carrera` VARCHAR(7) NULL,
  PRIMARY KEY (`matricula`),
  UNIQUE INDEX `matricula_UNIQUE` (`matricula` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `proyecto_final_bd`.`MATERIAS`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyecto_final_bd`.`MATERIAS` ;

CREATE TABLE IF NOT EXISTS `proyecto_final_bd`.`MATERIAS` (
  `clave` VARCHAR(7) NOT NULL,
  `nombre_materia` VARCHAR(255) NULL,
  PRIMARY KEY (`clave`),
  UNIQUE INDEX `clave_UNIQUE` (`clave` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `proyecto_final_bd`.`PROFESORES`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyecto_final_bd`.`PROFESORES` ;

CREATE TABLE IF NOT EXISTS `proyecto_final_bd`.`PROFESORES` (
  `nomina` VARCHAR(10) NOT NULL,
  `nombre` VARCHAR(50) NULL,
  PRIMARY KEY (`nomina`),
  UNIQUE INDEX `nomina_UNIQUE` (`nomina` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `proyecto_final_bd`.`GRUPOS`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyecto_final_bd`.`GRUPOS` ;

CREATE TABLE IF NOT EXISTS `proyecto_final_bd`.`GRUPOS` (
  `id` INT NOT NULL,
  `ciclo` VARCHAR(4) NULL,
  `num_grupo` SMALLINT NULL,
  `clave` VARCHAR(7) NOT NULL,
  PRIMARY KEY (`id`, `clave`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_GRUPOS_MATERIAS1_idx` (`clave` ASC),
  CONSTRAINT `fk_GRUPOS_MATERIAS1`
    FOREIGN KEY (`clave`)
    REFERENCES `proyecto_final_bd`.`MATERIAS` (`clave`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `proyecto_final_bd`.`HORARIOS`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyecto_final_bd`.`HORARIOS` ;

CREATE TABLE IF NOT EXISTS `proyecto_final_bd`.`HORARIOS` (
  `id` INT UNSIGNED NULL AUTO_INCREMENT,
  `dia` CHAR NULL,
  `hora_inicio` TIME NULL,
  `hora_final` TIME NULL,
  `GRUPOS_id` VARCHAR(5) NULL,
  `GRUPOS_id1` INT NOT NULL,
  `GRUPOS_clave` VARCHAR(7) NOT NULL,
  PRIMARY KEY (`id`, `GRUPOS_id1`, `GRUPOS_clave`),
  INDEX `fk_HORARIOS_GRUPOS1_idx` (`GRUPOS_id1` ASC, `GRUPOS_clave` ASC),
  CONSTRAINT `fk_HORARIOS_GRUPOS1`
    FOREIGN KEY (`GRUPOS_id1` , `GRUPOS_clave`)
    REFERENCES `proyecto_final_bd`.`GRUPOS` (`id` , `clave`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `proyecto_final_bd`.`ALUMNOS_has_GRUPO`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyecto_final_bd`.`ALUMNOS_has_GRUPO` ;

CREATE TABLE IF NOT EXISTS `proyecto_final_bd`.`ALUMNOS_has_GRUPO` (
  `ALUMNOS_matricula` VARCHAR(9) NOT NULL,
  `GRUPO_id` INT NOT NULL,
  PRIMARY KEY (`ALUMNOS_matricula`, `GRUPO_id`),
  INDEX `fk_ALUMNOS_has_GRUPO_GRUPO1_idx` (`GRUPO_id` ASC),
  INDEX `fk_ALUMNOS_has_GRUPO_ALUMNOS_idx` (`ALUMNOS_matricula` ASC),
  CONSTRAINT `fk_ALUMNOS_has_GRUPO_ALUMNOS`
    FOREIGN KEY (`ALUMNOS_matricula`)
    REFERENCES `proyecto_final_bd`.`ALUMNOS` (`matricula`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_ALUMNOS_has_GRUPO_GRUPO1`
    FOREIGN KEY (`GRUPO_id`)
    REFERENCES `proyecto_final_bd`.`GRUPOS` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `proyecto_final_bd`.`GRUPO_has_PROFESORES`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyecto_final_bd`.`GRUPO_has_PROFESORES` ;

CREATE TABLE IF NOT EXISTS `proyecto_final_bd`.`GRUPO_has_PROFESORES` (
  `GRUPO_id` INT NOT NULL,
  `PROFESORES_nomina` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`GRUPO_id`, `PROFESORES_nomina`),
  INDEX `fk_GRUPO_has_PROFESORES_PROFESORES1_idx` (`PROFESORES_nomina` ASC),
  INDEX `fk_GRUPO_has_PROFESORES_GRUPO1_idx` (`GRUPO_id` ASC),
  CONSTRAINT `fk_GRUPO_has_PROFESORES_GRUPO1`
    FOREIGN KEY (`GRUPO_id`)
    REFERENCES `proyecto_final_bd`.`GRUPOS` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_GRUPO_has_PROFESORES_PROFESORES1`
    FOREIGN KEY (`PROFESORES_nomina`)
    REFERENCES `proyecto_final_bd`.`PROFESORES` (`nomina`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
