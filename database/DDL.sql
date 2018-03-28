CREATE TABLE student
    (student_id integer primary key,
    student_number bigint not null,
    last_name nvarchar(100) not null,
    first_name nvarchar(100) not null,
    CONSTRAINT student_c1 UNIQUE (student_number));

CREATE TABLE unit 
    (unit_id integer primary key, 
    [name] nvarchar(100) not null, 
    [description] nvarchar(1000) null,
    CONSTRAINT unit_c1 UNIQUE ([name]));


CREATE TABLE [standard] 
    (standard_id integer primary key, 
    [name] nvarchar(100), 
    [description] nvarchar(1000) null, 
    CONSTRAINT standard_c1 UNIQUE ([name]));

CREATE TABLE unit_standard
    (unit_standard_id integer primary key,
    unit_id integer not null,
    standard_id integer not null,
    FOREIGN KEY (unit_id) REFERENCES [unit](unit_id),
    FOREIGN KEY (standard_id) REFERENCES [standard](standard_id),
    CONSTRAINT unit_standard_c1 UNIQUE (unit_id, standard_id));

