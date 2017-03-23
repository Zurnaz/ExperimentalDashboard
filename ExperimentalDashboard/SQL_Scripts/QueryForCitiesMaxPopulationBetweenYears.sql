SELECT p.CityId, p.population, p.Certainty, max(p.year)
FROM CityPopulation p
INNER JOIN 
	(
		SELECT c.CityName, c.Country, p.certainty, max(Population) as Population
		FROM CityPopulation p
		INNER JOIN Cities c ON c.CityId = p.CityId 
		WHERE year >= 1000 AND year <= 2000
		GROUP BY c.CityId, c.CityName, c.Country, p.certainty
	)  m
ON (p.CityId = m.CityId AND p.Population = m.Population)
GROUP BY p.CityId, p.population, p.Certainty
