
create TABLE specializare( acronim CHAR(10) PRIMARY KEY NOT NULL,
							nume CHAR(50),
							domeniu CHAR(25),
							program_studii CHAR(20),
							nr_studenti INT, 
							nr_promovati INT);

CREATE TABLE student (cod_matricol CHAR(10) PRIMARY KEY NOT NULL,
					  nume CHAR(20) NOT NULL CHECK(nume=upper(nume)),
					  initiala_tata CHAR(3),
					  prenume CHAR(45) check(prenume=upper(prenume)),
					  an_curent INT,
					  grupa_curenta INT,
                      acronim CHAR(10) FOREIGN KEY REFERENCES specializare(acronim) /*legatura intre tabelul student si tabelul specializare */
					  );

CREATE TABLE import_secretar( cod_matricol  CHAR(10)PRIMARY KEY NOT NULL,
							  FOREIGN KEY(cod_matricol) REFERENCES student(cod_matricol),
							  medie_gen_an_anterior FLOAT,
                              medie_gen_sem_anterior FLOAT,
                              medie_admitere FLOAT,
                              medie_bac FLOAT);

CREATE TABLE completate (cod_matricol CHAR(10) PRIMARY KEY NOT NULL, 
						 FOREIGN KEY(cod_matricol) REFERENCES student(cod_matricol),
						 email char(50),
						 an_inmatriculare INT, 
						 venit_lunar_membru INT, 
						 venit_lunar_membru_secretar INT, 
						 contributii_stiintifice BIT,
						 diplome_premii BIT,
						 acord_GDPR BIT,
						 nume_arhiva_docs_sociala CHAR(50),
						 cale_arhiva CHAR(120),
						 tip_arhiva CHAR(20),
						 CNP CHAR(15),
						 alte_detalii CHAR(120),
						 IBAN CHAR(20),
						 nume_fisier_extras_cont CHAR(45),
						 cale_extras_cont CHAR(80)
						 );
CREATE TABLE comisie(cod_comisie CHAR(10) PRIMARY KEY NOT NULL,
					 nume CHAR(50)
					);
CREATE TABLE membru(email CHAR(50) PRIMARY KEY NOT NULL,
					nume CHAR(50) CHECK(nume = upper(nume)) NOT NULL,
					prenume CHAR(50) CHECK(prenume = upper(prenume)) NOT NULL,
					functie CHAR(30) NOT NULL,
					cod_comisie char(10) FOREIGN KEY REFERENCES comisie(cod_comisie)
				   );
CREATE TABLE bursa(cod CHAR(10) PRIMARY KEY NOT NULL,
			       nume CHAR(30),
				   tip CHAR(20),
				   data_limita_solicitare DATE,
				   data_limita_recenzie DATE,
				   data_limita_contestatie DATE,
				   data_inceput DATE,
				   data_final DATE,
				   descriere CHAR(100),
				   suma FLOAT,
				   buget FLOAT,
				   nr_burse INT,
				   cod_comisie CHAR(10) FOREIGN KEY REFERENCES comisie(cod_comisie)
				  );

CREATE TABLE solicitare(cod_matricol CHAR(10) NOT NULL FOREIGN KEY REFERENCES student(cod_matricol), 
                        cod_bursa CHAR(10) NOT NULL FOREIGN KEY REFERENCES bursa(cod),
						PRIMARY KEY(cod_matricol, cod_bursa),
						data_solicitare DATE,
						data_ultimei_modificari DATE,
						status CHAR(20),
						observatii_secretar CHAR(100),
						observatii_sef_comisie CHAR(100),
						data_ultimei_recenzii_sef CHAR(50)
						);


CREATE TABLE info_evaluare_solicitare(cod_matricol CHAR(10) NOT NULL, cod_bursa CHAR(10) NOT NULL, email CHAR(50) NOT NULL,
									  PRIMARY KEY(cod_matricol, cod_bursa, email),
									  FOREIGN KEY(cod_matricol, cod_bursa) REFERENCES solicitare(cod_matricol, cod_bursa),
									  FOREIGN KEY(email) references membru(email),
									  observatii CHAR(100),
									  data_ultimei_recenzii DATE									  
									  );

CREATE TABLE contesta(cod_matricol CHAR(10) NOT NULL FOREIGN KEY REFERENCES student(cod_matricol), 
				      cod_bursa CHAR(10) NOT NULL FOREIGN KEY REFERENCES bursa(cod),
					  PRIMARY KEY(cod_matricol, cod_bursa),
					  data_contestatie DATE,
					  motiv CHAR(100),
					  status CHAR(20),
					  observatii_sef_comisie CHAR(100)
					  );

CREATE TABLE beneficiaza(cod_matricol CHAR(10) NOT NULL FOREIGN KEY REFERENCES student(cod_matricol), 
					    cod_bursa CHAR(10) NOT NULL FOREIGN KEY REFERENCES bursa(cod), 
						PRIMARY KEY(cod_matricol, cod_bursa),
						data_validare DATE,
						nume_fisier_decl_acceptare CHAR(50),
						cale_fisier CHAR(80) NOT NULL,
						);

CREATE TABLE criteriu(cod_criteriu CHAR(10) PRIMARY KEY NOT NULL,
					  descriere CHAR(120) 
					  );

CREATE TABLE acorda(cod_criteriu CHAR(10) NOT NULL FOREIGN KEY REFERENCES criteriu(cod_criteriu), 
					cod_bursa CHAR(10) NOT NULL FOREIGN KEY REFERENCES bursa(cod),
					PRIMARY KEY(cod_criteriu, cod_bursa) 
					);
