USE mysql_climsoft_db_v4;LOAD DATA INFILE 'climsoft_v4_sample_station_information.csv' IGNORE INTO TABLE station fields terminated by ',' (stationId,stationName,country,longitude,latitude,elevation);