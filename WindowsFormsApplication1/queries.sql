select distinct m.id AS id, m.title AS title
from medications m, diseasesMedications dm
where m.id = dm.idMedications AND dm.idDiseases in (1,3,4);

CREATE TABLE Medications(
   ID 		INTEGER PRIMARY KEY AUTOINCREMENT,
   TITLE   	CHAR(127),
   DESCRIPTION TEXT
);

CREATE TABLE Diseases(
   ID 		INTEGER PRIMARY KEY AUTOINCREMENT,
   TITLE  	CHAR(127)
);

CREATE TABLE Contraindications(
   IDMedications 	INTEGER,
   IDDiseases 		INTEGER
);

CREATE TABLE Symptoms(
   ID		INTEGER PRIMARY KEY AUTOINCREMENT,
   TITLE	CHAR(127)
);

CREATE TABLE DiseasesSymptoms(
   IDDiseases INTEGER,
   IDSymptoms INTEGER,
   FOREIGN KEY(IDDiseases) REFERENCES Diseases(ID),
   FOREIGN KEY(IDSymptoms) REFERENCES Symptoms(ID)
);

CREATE TABLE DiseasesMedications(
   IDDiseases INTEGER,
   IDMedications INTEGER,
   FOREIGN KEY(IDDiseases) REFERENCES Diseases(ID),
   FOREIGN KEY(IDMedications) REFERENCES Medications(ID)
);

INSERT INTO Medications(title) values('Лекарство_6');
INSERT INTO Diseases(title) values('Болезнь_1');
INSERT INTO Contraindications(IDMedications) values('');
INSERT INTO Contraindications(IDDiseases) values('');
INSERT INTO Symptoms(TITLE) values('');
INSERT INTO DiseasesSymptoms(IDDiseases) values('');
INSERT INTO DiseasesSymptoms(IDSymptoms) values('');
INSERT INTO DiseasesMedications(IDDiseases) values('');
INSERT INTO DiseasesMedications(IDMedications) values('');


INSERT INTO DiseasesMedications(IDDiseases) values('1');
INSERT INTO DiseasesMedications(IDMedications) values('1');
INSERT INTO DiseasesMedications(IDDiseases) values('3');
INSERT INTO DiseasesMedications(IDMedications) values('1');
INSERT INTO DiseasesMedications(IDDiseases) values('2');
INSERT INTO DiseasesMedications(IDMedications) values('2');
INSERT INTO DiseasesMedications(IDDiseases) values('4');
INSERT INTO DiseasesMedications(IDMedications) values('2');
INSERT INTO DiseasesMedications(IDDiseases) values('1');
INSERT INTO DiseasesMedications(IDMedications) values('3);
INSERT INTO DiseasesMedications(IDDiseases) values('3');
INSERT INTO DiseasesMedications(IDMedications) values('4');
INSERT INTO DiseasesMedications(IDDiseases) values('4');
INSERT INTO DiseasesMedications(IDMedications) values('4');
INSERT INTO DiseasesMedications(IDDiseases) values('1');
INSERT INTO DiseasesMedications(IDMedications) values('5');
INSERT INTO DiseasesMedications(IDDiseases) values('3');
INSERT INTO DiseasesMedications(IDMedications) values('5');
INSERT INTO DiseasesMedications(IDDiseases) values('4');
INSERT INTO DiseasesMedications(IDMedications) values('5');



