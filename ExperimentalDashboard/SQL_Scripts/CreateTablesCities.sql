CREATE TABLE  Cities(
	CityId INT NOT NULL,
	CityName VARCHAR(100) NOT NULL,
	OtherName VARCHAR(1000),
	Country VARCHAR(100),
	Latitude DECIMAL,
	Longitude DECIMAL,
	CONSTRAINT cities_pk PRIMARY KEY (CityId),
	CONSTRAINT city_u UNIQUE (city,country)
);

CREATE TABLE CityPopulation (
	CityId INT NOT NULL,
	Year SMALLINT NOT NULL,
	Population INT NOT NULL,
	Certainty TINYINT,
	CONSTRAINT uq_CityPopulation UNIQUE (CityId, year),
	CONSTRAINT fk_cities  FOREIGN KEY (CityId)  REFERENCES Cities(CityId)
);