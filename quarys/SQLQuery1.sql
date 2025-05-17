-- מחיקת כל הנתונים מהטבלה
DELETE FROM [dbo].[Clients];

-- הכנסת הנתונים מחדש עם שמות באנגלית
INSERT INTO [dbo].[Clients] ([Id], [Name], [AddressId], [Age], [PhoneNumber], [LeftEyeNumber], [RightEyeNumber], [Cylinder], [Email], [BackgroundDiseases], [HealthInsurance])
VALUES 
('0000000001', 'Yossi Cohen', 12, 25, '0501234567', 1.5, 1.75, 0.5, 'yossi@example.com', 0, 'meuhedet'),
('0000000002', 'Michal Levi', 13, 30, '0501234568', 2.0, 2.5, 0.75, 'michal@example.com', 1, 'klalit'),
('0000000003', 'David Israeli', 14, 22, '0501234569', 0.5, 0.75, 0.25, 'david@example.com', 0, 'macabi'),
('0000000004', 'Sarah Friedman', 15, 28, '0501234570', 2.5, 2.0, 0.5, 'sara@example.com', 1, 'meuhedet'),
('0000000005', 'Avi Rosen', 16, 35, '0501234571', 1.0, 1.25, 0.3, 'avi@example.com', 0, 'klalit'),
('0000000006', 'Hana Barak', 17, 40, '0501234572', 2.0, 2.5, 0.4, 'hana@example.com', 1, 'macabi'),
('0000000007', 'Ron Ben', 18, 29, '0501234573', 1.5, 1.75, 0.6, 'ron@example.com', 0, 'meuhedet'),
('0000000008', 'Talia Shimony', 19, 32, '0501234574', 0.75, 0.5, 0.2, 'talia@example.com', 1, 'klalit'),
('0000000009', 'Oren Barkovitz', 20, 27, '0501234575', 1.25, 1.0, 0.3, 'oren@example.com', 0, 'macabi'),
('0000000010', 'Mia Sofer', 21, 23, '0501234576', 1.8, 1.9, 0.5, 'mia@example.com', 1, 'meuhedet'),
('0000000011', 'Avigdor Stern', 22, 34, '0501234577', 2.2, 2.1, 0.7, 'avigdor@example.com', 0, 'klalit'),
('0000000012', 'Daniel Peretz', 23, 31, '0501234578', 1.4, 1.6, 0.8, 'daniel@example.com', 1, 'macabi'),
('0000000013', 'Shirley Goldstein', 24, 26, '0501234579', 2.3, 2.4, 0.9, 'shirley@example.com', 0, 'meuhedet'),
('0000000014', 'Yonatan Cooper', 25, 38, '0501234580', 1.6, 1.7, 0.5, 'yonatan@example.com', 1, 'klalit'),
('0000000015', 'Maia Navon', 26, 24, '0501234581', 0.9, 1.0, 0.3, 'maya@example.com', 0, 'macabi'),
('0000000016', 'Uri Mizrahi', 27, 33, '0501234582', 2.1, 2.2, 0.6, 'uri@example.com', 1, 'meuhedet'),
('0000000017', 'Natali Zamir', 28, 30, '0501234583', 1.9, 2.0, 0.4, 'natali@example.com', 0, 'klalit'),
('0000000018', 'Guy Cohen', 29, 29, '0501234584', 1.3, 1.4, 0.5, 'guy@example.com', 1, 'macabi'),
('0000000019', 'Roni Ezer', 30, 27, '0501234585', 2.0, 2.1, 0.7, 'roni@example.com', 0, 'meuhedet'),
('0000000020', 'Adi Chen', 31, 22, '0501234586', 1.2, 1.3, 0.5, 'adi@example.com', 1, 'klalit'),
('0000000021', 'Avigail Paz', 32, 34, '0501234587', 1.8, 1.9, 0.6, 'avigail@example.com', 0, 'macabi'),
('0000000022', 'Leon Avraham', 33, 36, '0501234588', 2.5, 2.6, 0.8, 'leon@example.com', 1, 'meuhedet'),
('0000000023', 'Dana Levi', 34, 25, '0501234589', 1.7, 1.8, 0.4, 'dana@example.com', 0, 'klalit'),
('0000000024', 'Shlomi Bar', 35, 28, '0501234590', 2.2, 2.3, 0.5, 'shlomi@example.com', 1, 'macabi'),
('0000000025', 'Omri Na’im', 36, 31, '0501234591', 1.5, 1.4, 0.3, 'omri@example.com', 0, 'meuhedet'),
('0000000026', 'Maor Ohion', 37, 29, '0501234592', 2.1, 2.2, 0.6, 'maor@example.com', 1, 'klalit'),
('0000000027', 'Ilan Rafael', 38, 33, '0501234593', 1.9, 1.8, 0.5, 'ilan@example.com', 0, 'macabi'),
('0000000028', 'Golan Rosen', 39, 40, '0501234594', 2.4, 2.5, 0.7, 'golan@example.com', 1, 'meuhedet'),
('0000000029', 'Tamar Friedman', 40, 26, '0501234595', 1.6, 1.7, 0.5, 'tamar@example.com', 0, 'klalit'),
('0000000030', 'Yoav Israeli', 41, 35, '0501234596', 2.3, 2.4, 0.5, 'yoav@example.com', 1, 'macabi'),
('0000000031', 'Roni Barak', 42, 24, '0501234597', 1.4, 1.5, 0.3, 'roni_b@example.com', 0, 'meuhedet'),
('0000000032', 'Einat Sela', 12, 30, '0501234598', 1.8, 1.9, 0.6, 'einat@example.com', 1, 'klalit'),
('0000000033', 'Eitan Golan', 13, 28, '0501234599', 2.0, 2.1, 0.4, 'eitan@example.com', 0, 'macabi'),
('0000000034', 'Liya Habib', 14, 29, '0501234600', 1.7, 1.8, 0.5, 'liya@example.com', 1, 'meuhedet'),
('0000000035', 'Orly Oz', 15, 32, '0501234601', 2.1, 2.2, 0.6, 'orly@example.com', 0, 'klalit'),
('0000000036', 'Raz Nimrod', 16, 34, '0501234602', 1.9, 1.8, 0.7, 'raz@example.com', 1, 'macabi'),
('0000000037', 'Nemrod Rafael', 17, 26, '0501234603', 2.2, 2.3, 0.5, 'nemrod@example.com', 0, 'meuhedet'),
('0000000038', 'Shaked Tamari', 18, 31, '0501234604', 1.5, 1.6, 0.3, 'shaked@example.com', 1, 'klalit'),
('0000000039', 'Ilana Tal', 19, 28, '0501234605', 2.0, 2.1, 0.6, 'ilana@example.com', 0, 'macabi'),
('0000000040', 'Yossi Fisher', 20, 30, '0501234606', 1.4, 1.5, 0.3, 'yosi@example.com', 1, 'meuhedet'),
('0000000041', 'Shani Gefen', 21, 29, '0501234607', 2.3, 2.4, 0.5, 'shani@example.com', 0, 'klalit'),
('0000000042', 'Roi Barkovitz', 22, 35, '0501234608', 1.8, 1.9, 0.6, 'roi@example.com', 1, 'macabi'),
('0000000043', 'Tamir Avraham', 23, 36, '0501234609', 2.1, 2.2, 0.7, 'tamir@example.com', 0, 'meuhedet'),
('0000000044', 'Orit Sela', 24, 32, '0501234610', 1.6, 1.7, 0.5, 'orit@example.com', 1, 'klalit'),
('0000000045', 'Michael Rosen', 25, 30, '0501234611', 2.0, 2.1, 0.4, 'michael@example.com', 0, 'macabi'),
('0000000046', 'Roni Ram', 26, 38, '0501234612', 1.5, 1.6, 0.3, 'roni_ram@example.com', 1, 'meuhedet'),
('0000000047', 'Ayelet Barak', 27, 34, '0501234613', 2.4, 2.5, 0.6, 'ayalet@example.com', 0, 'klalit'),
('0000000048', 'Idan Levi', 28, 29, '0501234614', 1.8, 1.9, 0.5, 'idan@example.com', 1, 'macabi'),
('0000000049', 'Shira Golan', 29, 27, '0501234615', 2.1, 2.2, 0.4, 'shira@example.com', 0, 'meuhedet'),
('0000000050', 'Alon Mizrahi', 30, 35, '0501234616', 1.4, 1.5, 0.3, 'alon@example.com', 1, 'klalit');




DELETE FROM [dbo].[Doctors];
INSERT INTO [dbo].[Doctors] (Id, Name, AddressId, Specialization) VALUES
('123456789', 'David Cohen', 12, 'Cataract'),
('234567890', 'Michael Levi', 13, 'Laser'),
('345678901', 'Daniel Katz', 14, 'Ophthalmologist'),
('456789012', 'Joshua Friedman', 15, 'Optometrist'),
('567890123', 'Eli Schwartz', 16, 'Cataract'),
('678901234', 'Ariel Rosen', 17, 'Laser'),
('789012345', 'Noah Stein', 18, 'Ophthalmologist'),
('890123456', 'Samuel Gold', 19, 'Optometrist'),
('901234567', 'Yosef Adler', 20, 'Cataract'),
('012345678', 'Avraham Cohen', 21, 'Laser'),
('123456780', 'Yitzhak Levi', 22, 'Ophthalmologist'),
('234567891', 'Moshe Kaplan', 23, 'Optometrist');
