[System.Serializable]
public class InstitutesData
{
    public static string[][] examSets = new string[][] {   new string[] { "Математика (профиль)", "Русский язык", "Физика/Химия/Информатика и ИКТ" },
                                        new string[] { "Математика (профиль)", "Русский язык", "Обществознание/История/География/Иностранный язык" },
                                        new string[] { "Математика (профиль)", "Русский язык", "Физика/Химия/География/Информатика и ИКТ" },
                                        new string[] { "История", "Русский язык", "Обществознание/География/Биология/Иностранный язык" },
                                        new string[] { "Математика (профиль)", "Русский язык", "Информатика и ИКТ/Иностранный язык" },
                                        new string[] { "Математика (профиль)", "Русский язык", "История/Информатика и ИКТ/Иностранный язык" },
                                        new string[] { "Биология", "Русский язык", "Математика (профиль)/Обществознание/Иностранный язык" },
                                        new string[] { "Обществознание", "Русский язык", "Профессиональное испытание" },
                                        new string[] { "Обществознание", "Русский язык", "География/Информатика и ИКТ/Иностранный язык" },
                                        new string[] { "Математика (профиль)", "Русский язык", "Профессиональное испытание" },
                                        new string[] { "История", "Русский язык", "Обществознание/География/Иностранный язык" },
                                        new string[] { "История", "Русский язык", "Обществознание/Литература/География/Информатика и ИКТ/Иностранный язык" },
    };

    public static readonly Institute[] institutes = new Institute[] { 
    
    new Institute("Институт тяги и подвижного состава",
        new Profession[] { new Profession("Эксплуатация транспортно-технологических машин и комплексов", examSets[0]),
            new Profession("Машиностроение, профиль: \"Оборудование и технология сварочного производства\"", examSets[0]),
            new Profession("Наземные транспортно-технологические комплексы", examSets[0])},
            new Profession[] { new Profession("Подвижной состав железных дорог", examSets[0]),
            new Profession("Наземные транспортно-технологические средства", examSets[0])},
        "ауд. 3309, тел. 8 (4212) 40-70-10; 40-74-34"),

    new Institute("Институт управления, автоматизации и телекоммуникаций",
            new Profession[] { new Profession("Информационные системы и технологии", examSets[0]) ,
                new Profession("Инфокоммуникационные технологии и системы связи", examSets[0]),
                new Profession("Программная инженерия", examSets[0]),
                new Profession("Технология транспортных процессов, профиль: \"Логистика нефтегазового комплекса и транспортных систем\"", examSets[0])},
            new Profession[] { new Profession("Системы обеспечения движения поездов", examSets[0]),
                new Profession("Информационная безопасность автоматизированных систем", examSets[0]),
                new Profession("Эксплуатация железных дорог",examSets[0])},
            "ауд. 311, тел. 8 (4212) 40-74-38; 40-70-70"),

    new Institute("Институт экономики", new Profession[] { new Profession("Экономика", examSets[1]), new Profession("Менеджмент", examSets[1]) },
            new Profession[] { new Profession("Экономическая безопасность", examSets[1]) },
                        "ауд. 258, тел. 8 (4212) 40-75-20; 40-71-73"),

    new Institute("Институт транспортного строительства",
            new Profession[] { new Profession("Строительство", examSets[0]), new Profession("Градостроительсво", examSets[9]) },
            new Profession[] { new Profession("Строительство, эксплуатация, восстановление и техническое прикрытие автомобильных дорог, мостов и тоннелей", examSets[0]),
                        new Profession("Строительство железных дорог, мостов, транспортных тоннелей", examSets[0]),
                        new Profession("Строительсво уникальных зданий и сооружений (срок обучения 6 лет)", examSets[0])},
            "ауд. 321, тел. 8 (4212) 40-70-42; 40-73-24"),

    new Institute("Электроэнергетический институт",
            new Profession[] { new Profession("Электроэнергетика и электротехника", examSets[0]),
                        new Profession("Управление качеством, профиль: \"Управление качеством в производственно-технологических системах\"", examSets[0]) },
            new Profession[] { new Profession("Системы обеспечения движения поездов, специализация: \"Электроснабжение железных дорог\"", examSets[0]) },
            "ауд. 321, тел. 8 (4212) 40-70-42; 40-73-24"),

    new Institute("Естественнонаучный институт",
            new Profession[] { new Profession("Информатика и вычислительная техника, профиль: \"Технологии VR и AR\", \"Програмирование интеллектуальных и автоматизированных систем\"", examSets[0]),
                        new Profession("Прикладная информатика", examSets[0]),
                        new Profession("Нефтегазовое дело", examSets[2]),
                        new Profession("Техносферная безопасность", examSets[0]),
                        new Profession("Прикладная математика и информатика", examSets[0]),
                        new Profession("Интеллектуальные системы в гуманитарной сфере", examSets[4])},
            new Profession[] { new Profession("Пожарная безопасность", examSets[0]) },
            "ауд. 3444в, тел. 8 (4212) 40-77-23; 40-72-07"),

    new Institute("Социально-гуманитарный институт",
            new Profession[] { new Profession("Юриспруденция", examSets[5]),
                        new Profession("Международные отношения", examSets[10]),
                        new Profession("Документирование и архивоведение, профиль \"Цифровизация копроративного документооборота\"", examSets[11]),
                        new Profession("Сервис, профиль \"Медиа технологии, деловой и выставочный сервис", examSets[1]),
                        new Profession("Туризм", examSets[3])},
            new Profession[] { new Profession("Таможенное дело, специализация \"Таможенное дело и правоохранительная деятельность\"", examSets[7]),
                        new Profession("Таможенное дело, специализация \"Международное таможенное сотрудничество\"", examSets[8]),
                        new Profession("Психология служебной деятельности", examSets[6]),
                        new Profession("Правовое обеспечение национальной безопасности", examSets[5])},
            "ауд. 3415, тел. 8 (4212) 40-76-72; 40-71-29"),

    new Institute("Факультет воздушных сообщений",
            new Profession[] { new Profession("Технология транспортных процессов, профиль \"Организация перевозок и управление на воздушном транспорте\"", examSets[0]),
                        new Profession("Торговое дело, профиль \"Организация коммерческой и маркетинговой работы воздушном транспорте\"", examSets[1])},
            new Profession[] { },
            "ауд. 2803, тел. 8 (4212) 40-70-72; 40-74-96")
    };
}
