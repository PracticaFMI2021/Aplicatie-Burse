

CREATE TABLE useri(user_id INT PRIMARY KEY NOT NULL,
				   grup_id INT,
				   nume CHAR(30) NOT NULL,
				   prenume CHAR(30) NOT NULL,
				   data_creare DATE NOT NULL,
				   parola INT  
				   );

CREATE TABLE grupuri (id INT PRIMARY KEY NOT NULL,
					 grup CHAR(50));

CREATE TABLE drepturi_grup(id INT PRIMARY KEY NOT NULL,
						   grup_id INT,
						   drept_id INT);

CREATE TABLE drepturi(id INT PRIMARY KEY NOT NULL,
					   drepturi CHAR(100));

CREATE TABLE parole_useri(id INT PRIMARY KEY NOT NULL,
						  user_id INT,
						  data_creare DATE, 
						  parola CHAR(23));

CREATE TABLE user_logs(id INT PRIMARY KEY NOT NULL,
					   user_id INT, 
					   date_eveniment DATE,
					   eveniment CHAR(100));

ALTER TABLE useri 
ADD FOREIGN KEY (parola) REFERENCES parole_useri(id);

ALTER TABLE parole_useri 
ADD FOREIGN KEY (user_id) REFERENCES useri(user_id);

ALTER TABLE drepturi_grup
ADD FOREIGN KEY (drept_id) REFERENCES drepturi(id);

ALTER TABLE drepturi_grup
ADD FOREIGN KEY (grup_id) REFERENCES grupuri(id);

ALTER TABLE user_logs
ADD FOREIGN KEY (user_id) REFERENCES useri(user_id);

ALTER TABLE useri 
ADD FOREIGN KEY (grup_id) REFERENCES grupuri(id);


