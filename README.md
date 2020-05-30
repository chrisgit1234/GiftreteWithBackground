# GiftreteWithBackground
 This project shows the use of Background
## Steps in using Background
1. Create your project
2. Add nugget packages
3. Create folders:
* feature
* stepdefinitions
* pageobjects
* testdata
* utilities
* hooks
4. right click on feature file, select new item, select specflow and then feature file. enter the name of the file and click create.
5. in the feature file, create features wchich should contain all the fetures that are common to the scenarios
6. the remaining features should be written in each scenario accordingly
7. generate stepdefinition from the features
8. intantiate driver on the hooks with before and after scenario
9. on the pageobject initaite the iwebelement inspecting elements accordingly also write the method for each of the elements that is inspected
10. in the stepdefintions, call the methods written on the pageobjects.
11. run the test
