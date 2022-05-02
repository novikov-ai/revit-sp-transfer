# Example of exported result

---

* **SPF_ADSK_RUS_2019.txt** was used for creating the constants file (it's free for distributing by russian Autodesk bim community);
* [TransferResult](https://github.com/novikov-ai/revit-automation/tree/main/SharedParametersTransfer/ConstantsUses/TransferResult) contains two ways to handle the exported result:
  * You could use single file with a big amount of lines => **Exported_20220224.cs**
  * You could use [Partial Classes](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods) and create as many partial classes as many groups of parameters you have. Please, see the directory **ParameterGroups** and 3 classes inside, which were created accordinally 3 groups from File Shared Parameter (I didn't create all of the groups, hoping you catch the idea).
* **Attention!** You have only one thing to do before using the app. It's naming. Please, rename all the groups and parameters accordinaly with your coding style and conventions.

**A little help from me:** you should not rename imediately all of 100+ parameters, which were generated. You could rename group and then a parameter, once you needed it in your code. I hope that's the right way to found useless shared parameters and it could save you a lot of time.
