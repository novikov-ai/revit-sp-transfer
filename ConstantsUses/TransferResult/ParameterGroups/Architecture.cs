using System;
using SharedParametersTransfer.Core;
using SharedParametersTransfer.Models;

namespace ConstantsUses.TransferResult.ParameterGroups
{
    public partial class AllParametersSplitted
    {
        [GroupName("02 Обязательные АРХИТЕКТУРА")]
        public static class Architecture
        {
            /// <summary>
            /// ADSK_Индекс квартиры
            /// </summary>
            public static readonly ConstantParameter AdskApartmentIndex =
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
    }
}