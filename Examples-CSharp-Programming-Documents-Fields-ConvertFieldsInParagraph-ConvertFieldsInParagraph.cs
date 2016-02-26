// For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
// The path to the documents directory.
string dataDir = RunExamples.GetDataDir_WorkingWithFields();
string fileName = "TestFile.doc";
Document doc = new Document(dataDir + fileName);

// Pass the appropriate parameters to convert all IF fields to static text that are encountered only in the last 
// paragraph of the document.
FieldsHelper.ConvertFieldsToStaticText(doc.FirstSection.Body.LastParagraph, FieldType.FieldIf);

dataDir = dataDir + RunExamples.GetOutputFilePath(fileName);
// Save the document with fields transformed to disk.
doc.Save(dataDir);
