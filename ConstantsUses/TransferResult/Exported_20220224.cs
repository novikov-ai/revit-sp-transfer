using System;
using SharedParametersTransfer.Core;
using SharedParametersTransfer.Models;

namespace ConstantsUses.TransferResult
{
    public class AllParameters
    {
        [GroupName("01 Обязательные ОБЩИЕ")]
        public static class Common
        {
            /// <summary>
            /// ADSK_Единица измерения
            /// </summary>
            public static readonly ConstantParameter AdskUnit =
                new ConstantParameter("ADSK_Единица измерения", new Guid("4289cb19-9517-45de-9c02-5a74ebf5c86d"));

            /// <summary>
            /// ADSK_Завод-изготовитель
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Завод-изготовитель", new Guid("a8cdbf7b-d60a-485e-a520-447d2055f351"));

            /// <summary>
            /// ADSK_Зона
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Зона", new Guid("c78f0a7d-b68b-4d21-a247-1c8c6ced8bc5"));

            /// <summary>
            /// ADSK_Код изделия
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Код изделия", new Guid("2fd9e8cb-84f3-4297-b8b8-75f444e124ed"));

            /// <summary>
            /// ADSK_Марка
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Марка", new Guid("2204049c-d557-4dfc-8d70-13f19715e46d"));

            /// <summary>
            /// ADSK_Масса
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Масса", new Guid("32989501-0d17-4916-8777-da950841c6d7"));

            /// <summary>
            /// ADSK_Масса_Текст
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Масса_Текст", new Guid("a8832df7-0302-4a63-a6e1-47a01632b987"));

            /// <summary>
            /// ADSK_Материал обозначение
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Материал обозначение", new Guid("dbe7f282-3606-44cf-ac51-0f274c34c07b"));

            /// <summary>
            /// ADSK_Материал наименование
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Материал наименование", new Guid("87ce1509-068e-400f-afab-75df889463c7"));

            /// <summary>
            /// ADSK_Наименование
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Наименование", new Guid("e6e0f5cd-3e26-485b-9342-23882b20eb43"));

            /// <summary>
            /// ADSK_Наименование краткое
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Наименование краткое", new Guid("f194bf60-b880-4217-b793-1e0c30dda5e9"));

            /// <summary>
            /// ADSK_Обозначение
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Обозначение", new Guid("9c98831b-9450-412d-b072-7d69b39f4029"));

            /// <summary>
            /// ADSK_Позиция
            /// </summary>
            public static readonly ConstantParameter Parameter12 =
                new ConstantParameter("ADSK_Позиция", new Guid("ae8ff999-1f22-4ed7-ad33-61503d85f0f4"));

            /// <summary>
            /// ADSK_Предел огнестойкости
            /// </summary>
            public static readonly ConstantParameter Parameter13 =
                new ConstantParameter("ADSK_Предел огнестойкости", new Guid("4d902dad-86e1-4713-841a-a196798dbdf9"));

            /// <summary>
            /// ADSK_Примечание
            /// </summary>
            public static readonly ConstantParameter Parameter14 =
                new ConstantParameter("ADSK_Примечание", new Guid("a85b7661-26b0-412f-979c-66af80b4b2c3"));

            /// <summary>
            /// ADSK_Этаж
            /// </summary>
            public static readonly ConstantParameter Parameter15 =
                new ConstantParameter("ADSK_Этаж", new Guid("9eabf56c-a6cd-4b5c-a9d0-e9223e19ea3f"));

            /// <summary>
            /// ADSK_URL документации изделия
            /// </summary>
            public static readonly ConstantParameter Parameter16 =
                new ConstantParameter("ADSK_URL документации изделия",
                    new Guid("bddc75f4-8e27-4afc-add0-de7358bbf6d3"));

            /// <summary>
            /// ADSK_URL страницы изделия
            /// </summary>
            public static readonly ConstantParameter Parameter17 =
                new ConstantParameter("ADSK_URL страницы изделия", new Guid("c5f25d97-91ad-48c8-96e2-99eac6fbb3f1"));

            /// <summary>
            /// ADSK_Количество
            /// </summary>
            public static readonly ConstantParameter Parameter18 =
                new ConstantParameter("ADSK_Количество", new Guid("8d057bb3-6ccd-4655-9165-55526691fe3a"));
        }

        [GroupName("02 Обязательные АРХИТЕКТУРА")]
        public static class Group1
        {
            /// <summary>
            /// ADSK_Индекс квартиры
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Индекс квартиры", new Guid("a2985e5c-b28e-416a-acf6-7ab7e4ee6d86"));

            /// <summary>
            /// ADSK_Количество комнат
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Количество комнат", new Guid("f52108e1-0813-4ad6-8376-a38a1a23a55b"));

            /// <summary>
            /// ADSK_Коэффициент площади
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Коэффициент площади", new Guid("066eab6d-c348-4093-b0ca-1dfe7e78cb6e"));

            /// <summary>
            /// ADSK_Номер здания
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Номер здания", new Guid("eaa57141-68d3-4f89-8272-246328f8e77b"));

            /// <summary>
            /// ADSK_Номер квартиры
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Номер квартиры", new Guid("10fb72de-237e-4b9c-915b-8849b8907695"));

            /// <summary>
            /// ADSK_Номер помещения квартиры
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Номер помещения квартиры",
                    new Guid("69890ae1-d66e-4fe9-aced-024c27719f53"));

            /// <summary>
            /// ADSK_Номер секции
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Номер секции", new Guid("b59a3474-a5f4-430a-b087-a20f1a4eb57e"));

            /// <summary>
            /// ADSK_Площадь квартиры
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Площадь квартиры", new Guid("d3035d0f-b738-4407-a0e5-30787b92fa49"));

            /// <summary>
            /// ADSK_Площадь квартиры жилая
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Площадь квартиры жилая", new Guid("178e222b-903b-48f5-8bfc-b624cd67d13c"));

            /// <summary>
            /// ADSK_Площадь квартиры общая
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Площадь квартиры общая", new Guid("af973552-3d15-48e3-aad8-121fe0dda34e"));

            /// <summary>
            /// ADSK_Площадь с коэффициентом
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Площадь с коэффициентом", new Guid("9a0c14fa-b48c-40ce-8f95-6954dfe2a399"));

            /// <summary>
            /// ADSK_Тип квартиры
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Тип квартиры", new Guid("78e3b89c-eb68-4600-84a7-c523de162743"));

            /// <summary>
            /// ADSK_Тип помещения
            /// </summary>
            public static readonly ConstantParameter Parameter12 =
                new ConstantParameter("ADSK_Тип помещения", new Guid("56eb1705-f327-4774-b212-ef9ad2c860b0"));

            /// <summary>
            /// ADSK_Категория помещения
            /// </summary>
            public static readonly ConstantParameter Parameter13 =
                new ConstantParameter("ADSK_Категория помещения", new Guid("4c70cba0-574b-49cb-b5fd-c0637073e720"));

            /// <summary>
            /// ADSK_Позиция отделки
            /// </summary>
            public static readonly ConstantParameter Parameter14 =
                new ConstantParameter("ADSK_Позиция отделки", new Guid("38309243-d45f-4706-8f7c-78deb4ffa333"));

            /// <summary>
            /// ADSK_Наименование и номер цвета
            /// </summary>
            public static readonly ConstantParameter Parameter15 =
                new ConstantParameter("ADSK_Наименование и номер цвета",
                    new Guid("2c1f6e3d-cf4b-4c93-92fe-92e85acacd26"));

            /// <summary>
            /// ADSK_Наименование элемента фасада
            /// </summary>
            public static readonly ConstantParameter Parameter16 =
                new ConstantParameter("ADSK_Наименование элемента фасада",
                    new Guid("6a83444c-5937-49e7-b962-9460028281a7"));
        }

        [GroupName("03 Обязательные КОНСТРУКЦИИ")]
        public static class Group2
        {
            /// <summary>
            /// ADSK_Арматура гнутая
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Арматура гнутая", new Guid("2f9abac5-9608-4bb6-b509-d75b738777cf"));

            /// <summary>
            /// ADSK_Арматура семейством
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Арматура семейством", new Guid("fc0665b7-63dd-44f2-8805-558177eccfb1"));

            /// <summary>
            /// ADSK_Арматура эскиз
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Арматура эскиз", new Guid("ffd5b2a7-3613-4013-ab33-ae18647b7e98"));

            /// <summary>
            /// ADSK_Группа конструкций
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Группа конструкций", new Guid("f1314dc8-abb2-477c-bfb6-b096760b90c1"));

            /// <summary>
            /// ADSK_Длина балки аналитическая
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Длина балки аналитическая",
                    new Guid("bdc3ec94-1d14-43b2-8f30-6d150efab751"));

            /// <summary>
            /// ADSK_Длина балки истинная
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Длина балки истинная", new Guid("b62d0a35-0f0f-432d-9d3d-e821093a7d02"));

            /// <summary>
            /// ADSK_Класс арматуры
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Класс арматуры", new Guid("ebab2c09-c77a-4d25-8b41-43867fc5110c"));

            /// <summary>
            /// ADSK_Марка изделия
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Марка изделия", new Guid("92ae0425-031b-40a9-8904-023f7389963b"));

            /// <summary>
            /// ADSK_Марка конструкции
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Марка конструкции", new Guid("5d369dfb-17a2-4ae2-a1a1-bdfc33ba7405"));

            /// <summary>
            /// ADSK_Масса погонного метра
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Масса погонного метра", new Guid("d979a266-c540-434d-8574-f503ccbb72c1"));

            /// <summary>
            /// ADSK_Наименование профиля
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Наименование профиля", new Guid("c43fa9f2-df70-412d-aa0b-2c6106d5d7c0"));

            /// <summary>
            /// ADSK_Номер листа элемента
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Номер листа элемента", new Guid("68e483e3-4c06-494b-979e-4958d44d6f71"));

            /// <summary>
            /// ADSK_Способ подсчета массы
            /// </summary>
            public static readonly ConstantParameter Parameter12 =
                new ConstantParameter("ADSK_Способ подсчета массы", new Guid("aaea38b7-2a20-497c-af36-7f1261617260"));

            /// <summary>
            /// ADSK_Тип элемента КЖ
            /// </summary>
            public static readonly ConstantParameter Parameter13 =
                new ConstantParameter("ADSK_Тип элемента КЖ", new Guid("68df3fae-3e98-429a-a168-1b6f7a1485b0"));

            /// <summary>
            /// ADSK_Тип элемента КМ
            /// </summary>
            public static readonly ConstantParameter Parameter14 =
                new ConstantParameter("ADSK_Тип элемента КМ", new Guid("e44ced8e-6502-4492-90ed-a9277be479db"));

            /// <summary>
            /// ADSK_Эскиз сечения
            /// </summary>
            public static readonly ConstantParameter Parameter15 =
                new ConstantParameter("ADSK_Эскиз сечения", new Guid("3af62dec-67c7-44a4-a678-7b3bf4b7d6a0"));

            /// <summary>
            /// ADSK_Этап возведения
            /// </summary>
            public static readonly ConstantParameter Parameter16 =
                new ConstantParameter("ADSK_Этап возведения", new Guid("3e8a07f7-fc58-4c4b-8b94-f1138d543cdb"));
        }

        [GroupName("04 Обязательные ИНЖЕНЕРИЯ")]
        public static class Group3
        {
            /// <summary>
            /// ADSK_Классификация нагрузок
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Классификация нагрузок", new Guid("a3413727-1213-401f-8ff2-880522a42b91"));

            /// <summary>
            /// ADSK_Количество фаз
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Количество фаз", new Guid("d182b385-9e45-4e8b-b8da-725396848493"));

            /// <summary>
            /// ADSK_Количество фаз числовое
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Количество фаз числовое", new Guid("70b900b9-87fc-44bf-8c10-35fca4e76ed7"));

            /// <summary>
            /// ADSK_Коэффициент мощности
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Коэффициент мощности", new Guid("e3c1a4b0-78c8-49f5-b3c7-01869252c30e"));

            /// <summary>
            /// ADSK_Напряжение
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Напряжение", new Guid("be29221e-5b74-4a61-a253-4eb5f3b532d9"));

            /// <summary>
            /// ADSK_Номинальная мощность
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Номинальная мощность", new Guid("b4d13aad-0763-4481-b015-63137342d077"));

            /// <summary>
            /// ADSK_Полная мощность
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Полная мощность", new Guid("7bae0e4a-a125-4818-973a-00fd56bf853d"));

            /// <summary>
            /// ADSK_Потеря давления воздуха
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Потеря давления воздуха", new Guid("e6505622-4f7e-4529-a638-b368f37e9ecc"));

            /// <summary>
            /// ADSK_Потеря давления жидкости
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Потеря давления жидкости",
                    new Guid("ca816cbc-4f60-47c8-b0fe-14eddcc32b16"));

            /// <summary>
            /// ADSK_Расход воздуха
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Расход воздуха", new Guid("9b7d541b-cc04-4e41-949d-a0d6ed778a25"));

            /// <summary>
            /// ADSK_Расход воздуха вытяжной
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Расход воздуха вытяжной", new Guid("09a2cc33-19c8-4122-b344-37c037ea16a1"));

            /// <summary>
            /// ADSK_Расход воздуха приточный
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Расход воздуха приточный",
                    new Guid("5ea9d045-d650-4f7e-8eb1-8987b04f99f7"));

            /// <summary>
            /// ADSK_Расход ГВ
            /// </summary>
            public static readonly ConstantParameter Parameter12 =
                new ConstantParameter("ADSK_Расход ГВ", new Guid("5190f657-863c-4941-8e2d-c22128314d56"));

            /// <summary>
            /// ADSK_Расход канализационных стоков
            /// </summary>
            public static readonly ConstantParameter Parameter13 =
                new ConstantParameter("ADSK_Расход канализационных стоков",
                    new Guid("e66d951d-8d99-450f-9244-db1ea4850282"));

            /// <summary>
            /// ADSK_Расход теплоносителя
            /// </summary>
            public static readonly ConstantParameter Parameter14 =
                new ConstantParameter("ADSK_Расход теплоносителя", new Guid("cd095b4d-1973-4682-8f03-f187d07b890b"));

            /// <summary>
            /// ADSK_Расход ХВ
            /// </summary>
            public static readonly ConstantParameter Parameter15 =
                new ConstantParameter("ADSK_Расход ХВ", new Guid("0afc7eb9-a8be-48dd-b1a1-272c020fbfdf"));

            /// <summary>
            /// ADSK_Расход холодоносителя
            /// </summary>
            public static readonly ConstantParameter Parameter16 =
                new ConstantParameter("ADSK_Расход холодоносителя", new Guid("1b29d3e6-4799-44a4-8c1f-48c38eba9cd6"));

            /// <summary>
            /// ADSK_Расход жидкости
            /// </summary>
            public static readonly ConstantParameter Parameter17 =
                new ConstantParameter("ADSK_Расход жидкости", new Guid("8748b0ed-3053-4b02-a87b-8d31dbdde981"));

            /// <summary>
            /// ADSK_Свободный напор воздуха
            /// </summary>
            public static readonly ConstantParameter Parameter18 =
                new ConstantParameter("ADSK_Свободный напор воздуха", new Guid("e75f1a0c-344b-487e-9af9-282de2322bdb"));

            /// <summary>
            /// ADSK_Свободный напор жидкости
            /// </summary>
            public static readonly ConstantParameter Parameter19 =
                new ConstantParameter("ADSK_Свободный напор жидкости",
                    new Guid("24304268-9382-4399-a927-5e854d52d563"));

            /// <summary>
            /// ADSK_Тепловая мощность
            /// </summary>
            public static readonly ConstantParameter Parameter20 =
                new ConstantParameter("ADSK_Тепловая мощность", new Guid("be7d2b1b-1916-428f-87f0-d9ee8d4f1efe"));

            /// <summary>
            /// ADSK_Ток
            /// </summary>
            public static readonly ConstantParameter Parameter21 =
                new ConstantParameter("ADSK_Ток", new Guid("7e243149-8b16-4c8b-8161-cd7780048c99"));

            /// <summary>
            /// ADSK_Толщина стенки
            /// </summary>
            public static readonly ConstantParameter Parameter22 =
                new ConstantParameter("ADSK_Толщина стенки", new Guid("381b467b-3518-42bb-b183-35169c9bdfb3"));

            /// <summary>
            /// ADSK_Холодильная мощность
            /// </summary>
            public static readonly ConstantParameter Parameter23 =
                new ConstantParameter("ADSK_Холодильная мощность", new Guid("f07965f9-3490-4c68-9404-3fa6721c1c8c"));
        }

        [GroupName("05 Необязательные ОБЩИЕ")]
        public static class Group4
        {
            /// <summary>
            /// ADSK_Владелец вида
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Владелец вида", new Guid("e166f8d8-b4ec-4488-a7a1-b7ee4ebdce1b"));

            /// <summary>
            /// ADSK_Назначение вида
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Назначение вида", new Guid("e313f126-7e51-4a5d-a45a-7c6dfe02124a"));

            /// <summary>
            /// ADSK_Норма расхода
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Норма расхода", new Guid("ea7c17d4-0692-452d-a2d2-94c0d8b00169"));

            /// <summary>
            /// ADSK_Материал тип подсчета
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Материал тип подсчета", new Guid("86d9bdff-680f-499d-b4fe-3c15bd427464"));

            /// <summary>
            /// ADSK_Предел огнестойкости экземпляра
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Предел огнестойкости экземпляра",
                    new Guid("2f2eccb4-ce52-49e3-b09e-9b72291d711d"));

            /// <summary>
            /// ADSK_Группирование
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Группирование", new Guid("3de5f1a4-d560-4fa8-a74f-25d250fb3401"));

            /// <summary>
            /// ADSK_Комплект
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Комплект", new Guid("8dd021be-382d-4776-afd4-75996e351de3"));

            /// <summary>
            /// ADSK_Материал
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Материал", new Guid("8b5e61a2-b091-491c-8092-0b01a55d4f44"));

            /// <summary>
            /// ADSK_Версия семейства
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Версия семейства", new Guid("85cd0032-c9ee-4cd3-8ffa-b2f1a05328e3"));

            /// <summary>
            /// ADSK_Версия Revit
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Версия Revit", new Guid("37384649-c3c8-4fc2-a08e-c2206438f528"));

            /// <summary>
            /// ADSK_Примечание к виду
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Примечание к виду", new Guid("e9853794-9790-4a53-a5c9-566106357d81"));
        }

        [GroupName("06 Необязательные АРХИТЕКТУРА")]
        public static class Group5
        {
            /// <summary>
            /// ADSK_Отверстие_Высота
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Отверстие_Высота", new Guid("bc4e92d8-db66-4e93-8923-3af6e2dc8599"));

            /// <summary>
            /// ADSK_Отверстие_Глубина
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Отверстие_Глубина", new Guid("40b92c1c-1fb2-4492-b339-9754be36c31a"));

            /// <summary>
            /// ADSK_Отверстие_Отметка от нуля
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Отверстие_Отметка от нуля",
                    new Guid("6ec2f9e9-3d50-4d75-a453-26ef4e6d1625"));

            /// <summary>
            /// ADSK_Отверстие_Отметка от этажа
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Отверстие_Отметка от этажа",
                    new Guid("e4793a44-6050-45b3-843e-cfb49d9191c5"));

            /// <summary>
            /// ADSK_Отверстие_Отметка этажа
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Отверстие_Отметка этажа", new Guid("44f7ce8a-2926-4514-bacb-423bd4ac3847"));

            /// <summary>
            /// ADSK_Отверстие_Функция
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Отверстие_Функция", new Guid("d1f527c4-8806-4e6f-8368-bc581b3e730d"));

            /// <summary>
            /// ADSK_Отверстие_Ширина
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Отверстие_Ширина", new Guid("096bc30e-3c95-4637-84d5-9f6bf45d8676"));

            /// <summary>
            /// ADSK_Откосы Глубина
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Откосы Глубина", new Guid("3af64655-cf56-46dd-ab11-8dc0b62051fa"));

            /// <summary>
            /// ADSK_Открывание
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Открывание", new Guid("b72e841d-76f0-4ba8-972c-24373c40eb34"));

            /// <summary>
            /// ADSK_Площадь проемов
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Площадь проемов", new Guid("18e3f49d-1315-415f-8359-8f045a7a8938"));

            /// <summary>
            /// ADSK_Толщина стены
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Толщина стены", new Guid("9350e48f-842b-4c46-a15d-2e36ab1f352f"));
        }

        [GroupName("07 Необязательные КОНСТРУКЦИИ")]
        public static class Group6
        {
            /// <summary>
            /// ADSK_Комплект чертежей
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Комплект чертежей", new Guid("e1b06433-f527-403c-8986-af9a01e6be7f"));

            /// <summary>
            /// ADSK_Подрезка длина
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Подрезка длина", new Guid("1b68c3da-54a4-4845-bd23-a3b5508259bd"));

            /// <summary>
            /// ADSK_Подрезка ширина
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Подрезка ширина", new Guid("9e4e68d8-4ba8-4973-8749-c5503470183c"));

            /// <summary>
            /// ADSK_Категория проема
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Категория проема", new Guid("510d0b4e-46b0-44c8-b0c5-f4cf862ea57b"));

            /// <summary>
            /// ADSK_Текст отметка расположения
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Текст отметка расположения",
                    new Guid("3644423a-f49d-422d-809e-e10647234f35"));

            /// <summary>
            /// ADSK_Элемент круглый
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Элемент круглый", new Guid("a1c04654-fee3-403d-a0b6-88f31ccbe285"));

            /// <summary>
            /// ADSK_Наименование_Префикс
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Наименование_Префикс", new Guid("3aa2840f-b18e-4ca0-95bb-9784cc9b532f"));

            /// <summary>
            /// ADSK_Наименование_Текст1
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Наименование_Текст1", new Guid("3601a2b2-2cdc-4e35-bb35-1de1737c45a8"));

            /// <summary>
            /// ADSK_Размер_В погонных метрах
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Размер_В погонных метрах",
                    new Guid("844a01e2-19fc-4dc5-baa0-a4bda30ef1f6"));

            /// <summary>
            /// ADSK_Размер_Смещение от уровня
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Размер_Смещение от уровня",
                    new Guid("515dc061-93ce-40e4-859a-e29224d80a10"));

            /// <summary>
            /// ADSK_Размер_Высота базового уровня
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Размер_Высота базового уровня",
                    new Guid("9f5f7e49-616e-436f-9acc-5305f34b6933"));

            /// <summary>
            /// ADSK_Размер_Отметка расположения
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Размер_Отметка расположения",
                    new Guid("6ca8be7d-c26e-4287-bef4-a95cbbccfe39"));

            /// <summary>
            /// ADSK_Количество позиций
            /// </summary>
            public static readonly ConstantParameter Parameter12 =
                new ConstantParameter("ADSK_Количество позиций", new Guid("dc574e96-c663-45ee-890f-a43fee4a906e"));

            /// <summary>
            /// ADSK_Позиция ведомость элементов
            /// </summary>
            public static readonly ConstantParameter Parameter13 =
                new ConstantParameter("ADSK_Позиция ведомость элементов",
                    new Guid("3e5e3615-7f31-4464-93db-2e53bb3f99e2"));

            /// <summary>
            /// ADSK_Усилие_M
            /// </summary>
            public static readonly ConstantParameter Parameter14 =
                new ConstantParameter("ADSK_Усилие_M", new Guid("8bba29ca-bedb-4ade-b820-85c1798bc6f5"));

            /// <summary>
            /// ADSK_Усилие_N
            /// </summary>
            public static readonly ConstantParameter Parameter15 =
                new ConstantParameter("ADSK_Усилие_N", new Guid("82f1d967-0ffc-4b9f-866e-7e2f476cc952"));

            /// <summary>
            /// ADSK_Усилие_Q
            /// </summary>
            public static readonly ConstantParameter Parameter16 =
                new ConstantParameter("ADSK_Усилие_Q", new Guid("e8ce3a4c-1b9f-4cdf-a821-7c0195de5d2e"));

            /// <summary>
            /// ADSK_Код металлопроката
            /// </summary>
            public static readonly ConstantParameter Parameter17 =
                new ConstantParameter("ADSK_Код металлопроката", new Guid("32a47c7f-e91d-4a8e-bf24-927cb679b4d1"));

            /// <summary>
            /// ADSK_Шаг элементов
            /// </summary>
            public static readonly ConstantParameter Parameter18 =
                new ConstantParameter("ADSK_Шаг элементов", new Guid("5d7cb726-ac59-4f05-a902-8fdffa796d15"));

            /// <summary>
            /// ADSK_Незаданный параметр
            /// </summary>
            public static readonly ConstantParameter Parameter19 =
                new ConstantParameter("ADSK_Незаданный параметр", new Guid("e72df02b-bdcf-464b-81c8-3973d22fc4e3"));

            /// <summary>
            /// ADSK_Форма отгибами
            /// </summary>
            public static readonly ConstantParameter Parameter20 =
                new ConstantParameter("ADSK_Форма отгибами", new Guid("cf9822bc-c607-4f8e-abc9-e95c23d1bf4b"));

            /// <summary>
            /// ADSK_Форма арматуры
            /// </summary>
            public static readonly ConstantParameter Parameter21 =
                new ConstantParameter("ADSK_Форма арматуры", new Guid("e2fa6173-f661-4eef-ac43-0946070a8e19"));

            /// <summary>
            /// ADSK_Деталь_Префикс
            /// </summary>
            public static readonly ConstantParameter Parameter22 =
                new ConstantParameter("ADSK_Деталь_Префикс", new Guid("419bcb08-39b2-4bc6-8da9-6cce92680a53"));

            /// <summary>
            /// ADSK_Длина арматуры
            /// </summary>
            public static readonly ConstantParameter Parameter23 =
                new ConstantParameter("ADSK_Длина арматуры", new Guid("ceadf021-b887-4539-93af-a1e8b82bcf71"));

            /// <summary>
            /// ADSK_Длина арматуры по детали
            /// </summary>
            public static readonly ConstantParameter Parameter24 =
                new ConstantParameter("ADSK_Длина арматуры по детали",
                    new Guid("e79d71cd-d3a4-44d0-9ae7-31a069486cfb"));

            /// <summary>
            /// ADSK_Диаметр арматуры
            /// </summary>
            public static readonly ConstantParameter Parameter25 =
                new ConstantParameter("ADSK_Диаметр арматуры", new Guid("a13859b3-a733-4df0-ba54-ba74966408e9"));

            /// <summary>
            /// ADSK_A
            /// </summary>
            public static readonly ConstantParameter Parameter26 =
                new ConstantParameter("ADSK_A", new Guid("1410523e-9de2-49e4-afc8-c4550f9ec693"));

            /// <summary>
            /// ADSK_B
            /// </summary>
            public static readonly ConstantParameter Parameter27 =
                new ConstantParameter("ADSK_B", new Guid("f8319615-f8a1-447c-9f0d-074cab3a620d"));

            /// <summary>
            /// ADSK_C
            /// </summary>
            public static readonly ConstantParameter Parameter28 =
                new ConstantParameter("ADSK_C", new Guid("018aa7ff-e85a-421b-aade-992341c61cac"));

            /// <summary>
            /// ADSK_D
            /// </summary>
            public static readonly ConstantParameter Parameter29 =
                new ConstantParameter("ADSK_D", new Guid("16dfbbd1-6716-417e-bcb8-2f46e9e82b6a"));

            /// <summary>
            /// ADSK_E
            /// </summary>
            public static readonly ConstantParameter Parameter30 =
                new ConstantParameter("ADSK_E", new Guid("cc269dd1-9836-43d0-8162-c961a95b208b"));

            /// <summary>
            /// ADSK_F
            /// </summary>
            public static readonly ConstantParameter Parameter31 =
                new ConstantParameter("ADSK_F", new Guid("ad15e7b1-fa49-4f53-83be-8a787fa55da0"));

            /// <summary>
            /// ADSK_G
            /// </summary>
            public static readonly ConstantParameter Parameter32 =
                new ConstantParameter("ADSK_G", new Guid("28a36bac-b53c-4eaa-8e82-01f9d5ada388"));

            /// <summary>
            /// ADSK_Q
            /// </summary>
            public static readonly ConstantParameter Parameter33 =
                new ConstantParameter("ADSK_Q", new Guid("16d061ff-5052-418b-a0fd-780e418ab561"));

            /// <summary>
            /// ADSK_R
            /// </summary>
            public static readonly ConstantParameter Parameter34 =
                new ConstantParameter("ADSK_R", new Guid("24e7201d-b044-40c1-9a65-0a3f0b5121bf"));

            /// <summary>
            /// ADSK_x
            /// </summary>
            public static readonly ConstantParameter Parameter35 =
                new ConstantParameter("ADSK_x", new Guid("64629355-807f-46a1-975f-80d2ddc94100"));

            /// <summary>
            /// ADSK_x'
            /// </summary>
            public static readonly ConstantParameter Parameter36 =
                new ConstantParameter("ADSK_x'", new Guid("6991bc73-7369-49ae-8634-7228122c7c39"));

            /// <summary>
            /// ADSK_Диаметр оправки арматуры
            /// </summary>
            public static readonly ConstantParameter Parameter37 =
                new ConstantParameter("ADSK_Диаметр оправки арматуры",
                    new Guid("e075d838-f49d-4fdd-af00-a5ba03fdd14a"));

            /// <summary>
            /// ADSK_A_bent
            /// </summary>
            public static readonly ConstantParameter Parameter38 =
                new ConstantParameter("ADSK_A_bent", new Guid("af0333c9-6bdf-44ee-996d-6f1e3bcdec25"));

            /// <summary>
            /// ADSK_B_bent
            /// </summary>
            public static readonly ConstantParameter Parameter39 =
                new ConstantParameter("ADSK_B_bent", new Guid("f3844c2b-be3e-41ef-991d-60c84a363122"));

            /// <summary>
            /// ADSK_C_bent
            /// </summary>
            public static readonly ConstantParameter Parameter40 =
                new ConstantParameter("ADSK_C_bent", new Guid("9a0745f5-2e98-4a0d-bf6e-535175609b92"));

            /// <summary>
            /// ADSK_R_bent
            /// </summary>
            public static readonly ConstantParameter Parameter41 =
                new ConstantParameter("ADSK_R_bent", new Guid("45aa1ebb-2e67-4063-af7b-55e489739b73"));

            /// <summary>
            /// ADSK_α_Angle
            /// </summary>
            public static readonly ConstantParameter Parameter42 =
                new ConstantParameter("ADSK_α_Angle", new Guid("bd379d5c-9815-417b-a22f-4491da6e044c"));

            /// <summary>
            /// ADSK_β_Angle
            /// </summary>
            public static readonly ConstantParameter Parameter43 =
                new ConstantParameter("ADSK_β_Angle", new Guid("508f827a-d74a-4ba7-862a-b14cfb07925c"));

            /// <summary>
            /// ADSK_Масса на единицу длины
            /// </summary>
            public static readonly ConstantParameter Parameter44 =
                new ConstantParameter("ADSK_Масса на единицу длины", new Guid("3d4f16d7-7f83-4522-a1e5-ef2dd847a082"));

            /// <summary>
            /// ADSK_Главная деталь изделия
            /// </summary>
            public static readonly ConstantParameter Parameter45 =
                new ConstantParameter("ADSK_Главная деталь изделия", new Guid("7b011a82-6ead-45ee-a188-7a7721dfb452"));

            /// <summary>
            /// ADSK_Главная деталь конструкции
            /// </summary>
            public static readonly ConstantParameter Parameter46 =
                new ConstantParameter("ADSK_Главная деталь конструкции",
                    new Guid("8df083dd-dcf5-410c-b984-f3e38f4d4314"));

            /// <summary>
            /// ADSK_Каркас
            /// </summary>
            public static readonly ConstantParameter Parameter47 =
                new ConstantParameter("ADSK_Каркас", new Guid("d7883213-d79a-453d-bb02-1cbdf48e28d0"));

            /// <summary>
            /// ADSK_Пространственный каркас
            /// </summary>
            public static readonly ConstantParameter Parameter48 =
                new ConstantParameter("ADSK_Пространственный каркас", new Guid("b37704f6-8bc0-4ff7-8fcc-aca2f08f0b97"));

            /// <summary>
            /// ADSK_Метка основы
            /// </summary>
            public static readonly ConstantParameter Parameter49 =
                new ConstantParameter("ADSK_Метка основы", new Guid("c9fc3f3a-0e04-42a5-bacc-6cb49f619cdb"));

            /// <summary>
            /// ADSK_Категория основы
            /// </summary>
            public static readonly ConstantParameter Parameter50 =
                new ConstantParameter("ADSK_Категория основы", new Guid("edd98a63-12d1-45c8-a9ff-495f82d1e7e5"));

            /// <summary>
            /// ADSK_Масса элемента
            /// </summary>
            public static readonly ConstantParameter Parameter51 =
                new ConstantParameter("ADSK_Масса элемента", new Guid("5913a1f9-0b38-4364-96fe-a6f3cb7fcc68"));

            /// <summary>
            /// ADSK_Основной материал элемента
            /// </summary>
            public static readonly ConstantParameter Parameter52 =
                new ConstantParameter("ADSK_Основной материал элемента",
                    new Guid("bb790509-b63a-46ee-a5ea-c7c72f27a53e"));

            /// <summary>
            /// ADSK_Выступ метиза
            /// </summary>
            public static readonly ConstantParameter Parameter53 =
                new ConstantParameter("ADSK_Выступ метиза", new Guid("5d6c238e-5c03-4b80-b345-b854439219ca"));

            /// <summary>
            /// ADSK_Длина резьбы метиза
            /// </summary>
            public static readonly ConstantParameter Parameter54 =
                new ConstantParameter("ADSK_Длина резьбы метиза", new Guid("5c2fbe5c-d53b-49a4-a933-b74320b7d33e"));

            /// <summary>
            /// ADSK_Марка метиза
            /// </summary>
            public static readonly ConstantParameter Parameter55 =
                new ConstantParameter("ADSK_Марка метиза", new Guid("4fb72145-6258-4ed0-a36c-69acb698d9d2"));

            /// <summary>
            /// ADSK_Высота строки_Изображение
            /// </summary>
            public static readonly ConstantParameter Parameter56 =
                new ConstantParameter("ADSK_Высота строки_Изображение",
                    new Guid("82ce3700-d9cf-4c34-9250-fe919853c3aa"));

            /// <summary>
            /// ADSK_Типоразмер элемента узла
            /// </summary>
            public static readonly ConstantParameter Parameter57 =
                new ConstantParameter("ADSK_Типоразмер элемента узла",
                    new Guid("5d46c406-eb6c-4b12-8d06-e6592d7fbdf8"));

            /// <summary>
            /// ADSK_Срубка сваи
            /// </summary>
            public static readonly ConstantParameter Parameter58 =
                new ConstantParameter("ADSK_Срубка сваи", new Guid("5fa9fdf9-f47e-4e70-8284-24324adfbc33"));

            /// <summary>
            /// ADSK_Закладная деталь
            /// </summary>
            public static readonly ConstantParameter Parameter59 =
                new ConstantParameter("ADSK_Закладная деталь", new Guid("3ca831f3-0b79-4929-b809-98527a59757d"));

            /// <summary>
            /// ADSK_Деталь наоборот
            /// </summary>
            public static readonly ConstantParameter Parameter60 =
                new ConstantParameter("ADSK_Деталь наоборот", new Guid("4fe4e7eb-07e6-4255-b1a2-250571d0a4dd"));
        }

        [GroupName("08 Необязательные ИНЖЕНЕРИЯ")]
        public static class Group7
        {
            /// <summary>
            /// ADSK_Вытяжка от МО
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Вытяжка от МО", new Guid("95147dbc-1602-418d-be36-414d242535d0"));

            /// <summary>
            /// ADSK_Диаметр условный
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Диаметр условный", new Guid("dc8a051d-a74f-4911-b198-6eeb2fbad659"));

            /// <summary>
            /// ADSK_Код крышки
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Код крышки", new Guid("6c103043-2d22-453e-8198-1ec15422d2b8"));

            /// <summary>
            /// ADSK_Код лотка
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Код лотка", new Guid("7b1cfa35-f6a0-45c8-b9b7-1acf90a7f02f"));

            /// <summary>
            /// ADSK_Код перегородки
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Код перегородки", new Guid("468bd542-deff-4e35-9d62-e8a32ddaee8d"));

            /// <summary>
            /// ADSK_Количество перегородок
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Количество перегородок", new Guid("1686df37-9577-4d04-a01e-10c33a3c7a4e"));

            /// <summary>
            /// ADSK_Компенсация вытяжки от МО
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Компенсация вытяжки от МО",
                    new Guid("be4e0aab-3198-4a55-8553-1459669d56d4"));

            /// <summary>
            /// ADSK_Наименование вытяжной системы
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Наименование вытяжной системы",
                    new Guid("f11ed0d9-3b91-4d35-bc44-01a579e45ce7"));

            /// <summary>
            /// ADSK_Наименование вытяжной системы от МО
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Наименование вытяжной системы от МО",
                    new Guid("699bd5d4-9be1-4fd8-8390-ffd85702565f"));

            /// <summary>
            /// ADSK_Наименование приточной системы
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Наименование приточной системы",
                    new Guid("5162f6a4-55c5-43e6-95f4-c06ace52faa0"));

            /// <summary>
            /// ADSK_Наименование системы компенсации МО
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Наименование системы компенсации МО",
                    new Guid("73ba98e9-8dde-4cd3-9b43-cfd16550c187"));

            /// <summary>
            /// ADSK_Номер стояка
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Номер стояка", new Guid("77c39bbd-2b91-4602-92a8-cf4e1e3b62c1"));

            /// <summary>
            /// ADSK_Перегородка лотка
            /// </summary>
            public static readonly ConstantParameter Parameter12 =
                new ConstantParameter("ADSK_Перегородка лотка", new Guid("17ad4831-d851-4801-9edc-791512278b0f"));

            /// <summary>
            /// ADSK_Позиция на схеме
            /// </summary>
            public static readonly ConstantParameter Parameter13 =
                new ConstantParameter("ADSK_Позиция на схеме", new Guid("95e5eb64-92e1-436b-80d8-f06505defc34"));

            /// <summary>
            /// ADSK_Потеря давления воздуха в нагревателе
            /// </summary>
            public static readonly ConstantParameter Parameter14 =
                new ConstantParameter("ADSK_Потеря давления воздуха в нагревателе",
                    new Guid("f51f7bf1-e50f-4563-aa17-4d1c12a2be81"));

            /// <summary>
            /// ADSK_Потеря давления воздуха в охладителе
            /// </summary>
            public static readonly ConstantParameter Parameter15 =
                new ConstantParameter("ADSK_Потеря давления воздуха в охладителе",
                    new Guid("35e504b6-9ff1-4feb-8179-3f145e701ca8"));

            /// <summary>
            /// ADSK_Приток к МО
            /// </summary>
            public static readonly ConstantParameter Parameter16 =
                new ConstantParameter("ADSK_Приток к МО", new Guid("d3714c67-b9f3-496e-889f-514f0dfcd138"));

            /// <summary>
            /// ADSK_Расчетная вытяжка
            /// </summary>
            public static readonly ConstantParameter Parameter17 =
                new ConstantParameter("ADSK_Расчетная вытяжка", new Guid("550f0463-71d7-4856-879c-11f9004d5789"));

            /// <summary>
            /// ADSK_Расчетное количество людей с временным пребыванием
            /// </summary>
            public static readonly ConstantParameter Parameter18 =
                new ConstantParameter("ADSK_Расчетное количество людей с временным пребыванием",
                    new Guid("02d85a9c-68d3-448d-b76c-db3537bcf9bf"));

            /// <summary>
            /// ADSK_Расчетное количество людей с постоянным пребыванием
            /// </summary>
            public static readonly ConstantParameter Parameter19 =
                new ConstantParameter("ADSK_Расчетное количество людей с постоянным пребыванием",
                    new Guid("c7feec1c-9972-4277-9bb1-b4ad207f7bca"));

            /// <summary>
            /// ADSK_Расчетный приток
            /// </summary>
            public static readonly ConstantParameter Parameter20 =
                new ConstantParameter("ADSK_Расчетный приток", new Guid("ff939149-328d-421c-93c3-3348a7e55697"));

            /// <summary>
            /// ADSK_Сопротивление воздушного фильтра
            /// </summary>
            public static readonly ConstantParameter Parameter21 =
                new ConstantParameter("ADSK_Сопротивление воздушного фильтра",
                    new Guid("8018c952-ae41-4f18-90cd-e5c59c0a1517"));

            /// <summary>
            /// ADSK_Температура в помещении
            /// </summary>
            public static readonly ConstantParameter Parameter22 =
                new ConstantParameter("ADSK_Температура в помещении", new Guid("8c261bcf-786d-42c1-b398-3784e3b793df"));

            /// <summary>
            /// ADSK_Температура воздуха на входе в нагреватель
            /// </summary>
            public static readonly ConstantParameter Parameter23 =
                new ConstantParameter("ADSK_Температура воздуха на входе в нагреватель",
                    new Guid("f4f0aae1-c6e9-40be-98d0-d58f84e9d0f0"));

            /// <summary>
            /// ADSK_Температура воздуха на входе в охладитель
            /// </summary>
            public static readonly ConstantParameter Parameter24 =
                new ConstantParameter("ADSK_Температура воздуха на входе в охладитель",
                    new Guid("35d72244-2520-43ec-b36f-1a2c4527988b"));

            /// <summary>
            /// ADSK_Температура воздуха на выходе из нагревателя
            /// </summary>
            public static readonly ConstantParameter Parameter25 =
                new ConstantParameter("ADSK_Температура воздуха на выходе из нагревателя",
                    new Guid("4cbc6f9d-54f5-4adc-879f-6ae38e5190c5"));

            /// <summary>
            /// ADSK_Температура воздуха на выходе из охладителя
            /// </summary>
            public static readonly ConstantParameter Parameter26 =
                new ConstantParameter("ADSK_Температура воздуха на выходе из охладителя",
                    new Guid("b8549b18-1d9f-430e-a2e8-cdbfa511712d"));

            /// <summary>
            /// ADSK_Теплопоступления от оборудования
            /// </summary>
            public static readonly ConstantParameter Parameter27 =
                new ConstantParameter("ADSK_Теплопоступления от оборудования",
                    new Guid("e7a2a3ab-3ec0-4e48-a31a-d329b3eee6c0"));

            /// <summary>
            /// ADSK_Теплопотери
            /// </summary>
            public static readonly ConstantParameter Parameter28 =
                new ConstantParameter("ADSK_Теплопотери", new Guid("05eb9c5e-c5a5-4c2c-b3fa-ca673358703c"));

            /// <summary>
            /// ADSK_Тип воздушного фильтра
            /// </summary>
            public static readonly ConstantParameter Parameter29 =
                new ConstantParameter("ADSK_Тип воздушного фильтра", new Guid("b0ad8b57-465a-4a9b-b409-0a4dd349f16a"));

            /// <summary>
            /// ADSK_Уклон
            /// </summary>
            public static readonly ConstantParameter Parameter30 =
                new ConstantParameter("ADSK_Уклон", new Guid("80d34cef-47d0-4c21-8409-6305fda3a286"));

            /// <summary>
            /// ADSK_Частота вращения вентилятора
            /// </summary>
            public static readonly ConstantParameter Parameter31 =
                new ConstantParameter("ADSK_Частота вращения вентилятора",
                    new Guid("e9f0a695-adc9-4670-a2c8-ee0d759cfef9"));

            /// <summary>
            /// ADSK_Частота вращения двигателя
            /// </summary>
            public static readonly ConstantParameter Parameter32 =
                new ConstantParameter("ADSK_Частота вращения двигателя",
                    new Guid("68b68804-e4b8-4a4c-881e-3d1c97c459b4"));

            /// <summary>
            /// ADSK_ПозицияКомплект
            /// </summary>
            public static readonly ConstantParameter Parameter33 =
                new ConstantParameter("ADSK_ПозицияКомплект", new Guid("cb017cdd-3a8f-4bd0-bf2e-577667423f8f"));

            /// <summary>
            /// ADSK_Класс взрывоопасной зоны
            /// </summary>
            public static readonly ConstantParameter Parameter34 =
                new ConstantParameter("ADSK_Класс взрывоопасной зоны",
                    new Guid("3894e623-d201-447e-976e-a438cc8eb4b2"));

            /// <summary>
            /// ADSK_Класс пожароопасной зоны
            /// </summary>
            public static readonly ConstantParameter Parameter35 =
                new ConstantParameter("ADSK_Класс пожароопасной зоны",
                    new Guid("c2706852-82e1-4780-8445-42385057ba51"));

            /// <summary>
            /// ADSK_Пусковой ток
            /// </summary>
            public static readonly ConstantParameter Parameter36 =
                new ConstantParameter("ADSK_Пусковой ток", new Guid("5bfeab53-72e6-4a57-9a12-d588fbafcc0c"));

            /// <summary>
            /// ADSK_Нормируемая освещенность
            /// </summary>
            public static readonly ConstantParameter Parameter37 =
                new ConstantParameter("ADSK_Нормируемая освещенность",
                    new Guid("732b6d7a-fb49-47ea-a4fc-bf0558c9808c"));

            /// <summary>
            /// ADSK_Категория и группа взрывоопасности по ПУЭ 
            /// </summary>
            public static readonly ConstantParameter Parameter38 =
                new ConstantParameter("ADSK_Категория и группа взрывоопасности по ПУЭ ",
                    new Guid("d27f1e8c-b628-4f87-8308-043fd047efd5"));

            /// <summary>
            /// ADSK_КПД
            /// </summary>
            public static readonly ConstantParameter Parameter39 =
                new ConstantParameter("ADSK_КПД", new Guid("c801a6d7-afa7-4085-9c0d-35827d64d71a"));

            /// <summary>
            /// ADSK_Кратность пускового тока
            /// </summary>
            public static readonly ConstantParameter Parameter40 =
                new ConstantParameter("ADSK_Кратность пускового тока",
                    new Guid("525f9bf4-8a03-44d8-9858-8ca9249d498d"));

            /// <summary>
            /// ADSK_Количество светильников
            /// </summary>
            public static readonly ConstantParameter Parameter41 =
                new ConstantParameter("ADSK_Количество светильников", new Guid("bd940efd-bae8-43c6-a839-454b44ff6baa"));
        }

        [GroupName("09 Заполнение штампа")]
        public static class Group8
        {
            /// <summary>
            /// ADSK_Титул Год выпуска
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Титул Год выпуска", new Guid("8a6e0145-58ea-4c2a-99b7-79e64e71f365"));

            /// <summary>
            /// ADSK_Титул Директор
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Титул Директор", new Guid("45d87fac-84ab-4bd0-a852-d6089c156543"));

            /// <summary>
            /// ADSK_Титул Строка 1 должность
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Титул Строка 1 должность",
                    new Guid("c5f4124e-9a7c-49d5-83e0-99bd05213e86"));

            /// <summary>
            /// ADSK_Титул Строка 1 фамллия
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Титул Строка 1 фамллия", new Guid("03d95fa9-d919-4add-b778-cb2a1208fb86"));

            /// <summary>
            /// ADSK_Титул Строка 2 должность
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Титул Строка 2 должность",
                    new Guid("8ddc6ae4-7741-450d-be39-2838a23a7758"));

            /// <summary>
            /// ADSK_Титул Строка 2 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Титул Строка 2 фамилия", new Guid("ebf4547f-2321-447d-9869-ef8ade144981"));

            /// <summary>
            /// ADSK_Титул_Номер тома
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Титул_Номер тома", new Guid("cf26d231-bbc4-4735-aa83-ecef9f44d030"));

            /// <summary>
            /// ADSK_Титул_Наименование документа
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Титул_Наименование документа",
                    new Guid("2f55778b-d403-4e61-b950-23a4e7d6fbc3"));

            /// <summary>
            /// ADSK_Титул_Вид документации
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Титул_Вид документации", new Guid("dd71ff90-123c-47fd-9b73-0855c8f63566"));

            /// <summary>
            /// ADSK_Штамп Боковой Инвентарный номер
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Штамп Боковой Инвентарный номер",
                    new Guid("1b54f7b8-55f5-4d54-b27e-7909865a501d"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 1 должность
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 1 должность",
                    new Guid("ab409417-2d5e-4f75-aa6a-204cc4ee6f74"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 1 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 1 фамилия",
                    new Guid("597f72d5-01a8-416b-805c-a18cbbc49254"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 2 должность
            /// </summary>
            public static readonly ConstantParameter Parameter12 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 2 должность",
                    new Guid("aa4e0636-b1b9-4ea6-8123-244a8679db0e"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 2 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter13 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 2 фамилия",
                    new Guid("73790284-e8c2-4717-a291-62460b2a596f"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 3 должность
            /// </summary>
            public static readonly ConstantParameter Parameter14 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 3 должность",
                    new Guid("ca0521c7-fdb9-4868-8047-9e81c665c9c7"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 3 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter15 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 3 фамилия",
                    new Guid("20e3931e-c22b-43ee-9256-9a2215b576a8"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 4 должность
            /// </summary>
            public static readonly ConstantParameter Parameter16 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 4 должность",
                    new Guid("1031a769-0efa-4811-a2bc-d2f2e15b7ba7"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 4 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter17 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 4 фамилия",
                    new Guid("c58ff5a3-7e40-4be6-af6d-f9fea2507a2d"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 5 должность
            /// </summary>
            public static readonly ConstantParameter Parameter18 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 5 должность",
                    new Guid("59e76a65-de10-4091-9763-6e923deab89a"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 5 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter19 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 5 фамилия",
                    new Guid("0abc2cd5-dab6-4a02-8b67-948c67c4f596"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 6 должность
            /// </summary>
            public static readonly ConstantParameter Parameter20 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 6 должность",
                    new Guid("bbdefec1-06b8-45e7-8e89-9e3ccbaf29b2"));

            /// <summary>
            /// ADSK_Штамп Боковой Строка 6 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter21 =
                new ConstantParameter("ADSK_Штамп Боковой Строка 6 фамилия",
                    new Guid("f2f78068-21e1-4e79-8597-6237c46a1399"));

            /// <summary>
            /// ADSK_Штамп Количество листов
            /// </summary>
            public static readonly ConstantParameter Parameter22 =
                new ConstantParameter("ADSK_Штамп Количество листов", new Guid("c2f49234-25d3-4abc-8638-dde90c2527aa"));

            /// <summary>
            /// ADSK_Штамп Имя листа Польз
            /// </summary>
            public static readonly ConstantParameter Parameter23 =
                new ConstantParameter("ADSK_Штамп Имя листа Польз", new Guid("cec3cc8c-d1fb-477b-9954-29cb60ce6656"));

            /// <summary>
            /// ADSK_Штамп Наименование объекта
            /// </summary>
            public static readonly ConstantParameter Parameter24 =
                new ConstantParameter("ADSK_Штамп Наименование объекта",
                    new Guid("c92f2899-a807-468d-8126-610f73aa6ffc"));

            /// <summary>
            /// ADSK_Штамп Раздел проекта
            /// </summary>
            public static readonly ConstantParameter Parameter25 =
                new ConstantParameter("ADSK_Штамп Раздел проекта", new Guid("7f0c8590-53a2-4ddf-aaed-c70eb9b687bc"));

            /// <summary>
            /// ADSK_Штамп Строка 1 должность
            /// </summary>
            public static readonly ConstantParameter Parameter26 =
                new ConstantParameter("ADSK_Штамп Строка 1 должность",
                    new Guid("7a9f273e-9664-4950-9bca-3d96b2670ba6"));

            /// <summary>
            /// ADSK_Штамп Строка 1 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter27 =
                new ConstantParameter("ADSK_Штамп Строка 1 фамилия", new Guid("a856a784-03da-4238-9bd9-9881b9938b8a"));

            /// <summary>
            /// ADSK_Штамп Строка 2 должность
            /// </summary>
            public static readonly ConstantParameter Parameter28 =
                new ConstantParameter("ADSK_Штамп Строка 2 должность",
                    new Guid("053e616e-cb3c-4dc5-8348-1c407e8e13a6"));

            /// <summary>
            /// ADSK_Штамп Строка 2 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter29 =
                new ConstantParameter("ADSK_Штамп Строка 2 фамилия", new Guid("6ca82d36-9c55-450a-a479-002c4736cc06"));

            /// <summary>
            /// ADSK_Штамп Строка 3 должность
            /// </summary>
            public static readonly ConstantParameter Parameter30 =
                new ConstantParameter("ADSK_Штамп Строка 3 должность",
                    new Guid("3dc943bc-1b11-47e6-9cde-880d51a9d861"));

            /// <summary>
            /// ADSK_Штамп Строка 3 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter31 =
                new ConstantParameter("ADSK_Штамп Строка 3 фамилия", new Guid("15284426-f3d8-4c55-9a6c-f9eea1393db3"));

            /// <summary>
            /// ADSK_Штамп Строка 4 должность
            /// </summary>
            public static readonly ConstantParameter Parameter32 =
                new ConstantParameter("ADSK_Штамп Строка 4 должность",
                    new Guid("c0f4a14d-0a30-4e08-a233-2a1a23db2403"));

            /// <summary>
            /// ADSK_Штамп Строка 4 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter33 =
                new ConstantParameter("ADSK_Штамп Строка 4 фамилия", new Guid("7f45f58c-1a5e-48f5-b292-bbf312c0bf2e"));

            /// <summary>
            /// ADSK_Штамп Строка 5 должность
            /// </summary>
            public static readonly ConstantParameter Parameter34 =
                new ConstantParameter("ADSK_Штамп Строка 5 должность",
                    new Guid("7e974de2-5e90-4af8-ba6a-601fe0c76b0f"));

            /// <summary>
            /// ADSK_Штамп Строка 5 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter35 =
                new ConstantParameter("ADSK_Штамп Строка 5 фамилия", new Guid("6153ed75-b3d0-4e9a-ade5-f851a2a4cab6"));

            /// <summary>
            /// ADSK_Штамп Строка 6 должность
            /// </summary>
            public static readonly ConstantParameter Parameter36 =
                new ConstantParameter("ADSK_Штамп Строка 6 должность",
                    new Guid("81f59847-bc5e-41a2-89f6-f840eaeb0258"));

            /// <summary>
            /// ADSK_Штамп Строка 6 фамилия
            /// </summary>
            public static readonly ConstantParameter Parameter37 =
                new ConstantParameter("ADSK_Штамп Строка 6 фамилия", new Guid("00178540-addd-412e-83e5-76db04dbb325"));
        }

        [GroupName("10 Размеры")]
        public static class Group9
        {
            /// <summary>
            /// ADSK_Размер_Высота
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Размер_Высота", new Guid("da753fe3-ecfa-465b-9a2c-02f55d0c2ff1"));

            /// <summary>
            /// ADSK_Размер_Длина
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Размер_Длина", new Guid("748a2515-4cc9-4b74-9a69-339a8d65a212"));

            /// <summary>
            /// ADSK_Размер_Толщина
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Размер_Толщина", new Guid("293f055d-6939-4611-87b7-9a50d0c1f50e"));

            /// <summary>
            /// ADSK_Размер_Ширина
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Размер_Ширина", new Guid("8f2e4f93-9472-4941-a65d-0ac468fd6a5d"));

            /// <summary>
            /// ADSK_Размер_Диаметр
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Размер_Диаметр", new Guid("9b679ab7-ea2e-49ce-90ab-0549d5aa36ff"));

            /// <summary>
            /// ADSK_Размер_Толщина полки
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Размер_Толщина полки", new Guid("31881d64-b1c3-45d2-ab34-baf2ee3e74e4"));

            /// <summary>
            /// ADSK_Размер_Толщина стенки
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Размер_Толщина стенки", new Guid("de129aa9-dae8-430d-8de8-f7f08388fcaa"));

            /// <summary>
            /// ADSK_Размер_Глубина
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Размер_Глубина", new Guid("14e630a8-bc4f-4556-9094-647e8f323f08"));

            /// <summary>
            /// ADSK_Размер_ДиаметрИзделия
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Размер_ДиаметрИзделия", new Guid("d6888dc7-7a03-40c3-9ac2-ab300c4e2c0a"));

            /// <summary>
            /// ADSK_Размер_Толщина основы
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Размер_Толщина основы", new Guid("398ea174-e0ef-4619-8db9-0b2c598d5206"));

            /// <summary>
            /// ADSK_Размер_УголПоворота
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Размер_УголПоворота", new Guid("a7397d18-200b-4659-b34c-3d8ae1c54317"));

            /// <summary>
            /// ADSK_Размер_Радиус
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Размер_Радиус", new Guid("f49bf488-e8a4-4517-ac59-e5ea2093350d"));
        }

        [GroupName("11 Обязательные ТХ")]
        public static class Group10
        {
            /// <summary>
            /// ADSK_Категория трубопровода
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Категория трубопровода", new Guid("423bf718-8d42-4476-8da8-e8f044140439"));

            /// <summary>
            /// ADSK_Граница трубопровода. Начало
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Граница трубопровода. Начало",
                    new Guid("90a72621-4840-4570-8e05-5af89b1e1880"));

            /// <summary>
            /// ADSK_Давление среды
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Давление среды", new Guid("05600b57-9321-4bc5-9bf8-7fa8f0c861b8"));

            /// <summary>
            /// ADSK_Цифровые обозначения вещества
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Цифровые обозначения вещества",
                    new Guid("e3ab405a-77c3-471e-ad85-c3ac5731a4d3"));

            /// <summary>
            /// ADSK_Транспортируемый продукт
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Транспортируемый продукт",
                    new Guid("842a8e88-d6dd-46ce-bf8e-210bedacc2d2"));

            /// <summary>
            /// ADSK_Наименование линии трубопровода
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Наименование линии трубопровода",
                    new Guid("94e6ed8b-e420-4028-85ed-cc330ba31dda"));

            /// <summary>
            /// ADSK_Температура среды
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Температура среды", new Guid("f41888a1-2044-4b03-ae34-50eae7175690"));

            /// <summary>
            /// ADSK_Граница трубопровода. Конец
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Граница трубопровода. Конец",
                    new Guid("2fb143bb-03d5-4f42-a6f0-2026167d1913"));
        }
    }
}