# TechnicalAssessment

## Task1
#### Screenshot:

<img width="723" alt="task1" src="https://user-images.githubusercontent.com/29879453/158009508-e9e673c4-fe3e-4c66-a890-e1686a5f1897.png">

## Task2
#### Adding Taxes
Add more taxes using `taxSystem.AddTax(name, taxPercent, threshold);` OR  `taxSystem.AddTax(name, taxPercent, threshold, maxIncomeToConsider)`

#### Example:
```
//will add a tax named "General Tax"  of 5% that will be incurred to the excess (amount above 400)
taxSystem.AddTax("General Tax", 5, 400); 
```

```
//will add a tax named "Additional Tax"  of 25% that will be incurred to the excess (amount above 800) without applying to amounts higher than 2000. 
taxSystem.AddTax("Additional Tax", 25, 800, 2000); 
```
#### Screenshot:

<img width="907" alt="task2" src="https://user-images.githubusercontent.com/29879453/158009518-7709de2a-4c4f-4bbb-8382-b96c79aba6ed.png">

## Task3
Provided with a recursive function(getDescendants) that given a DOM element will return an array that contains the element itself and all its descendants.

@param 1. **element**: is the DOM element

@param 2. **arr**: is the array the function fills with childs elements and ultimately returns, there's no need to specify this param, unless you want to start with a non-empty array.
                
#### Example:
```
getDescendants(document.getElementById('bottomMenu'))
```

#### Screenshot:

<img width="516" alt="Screen Shot 2022-03-12 at 4 03 18 AM" src="https://user-images.githubusercontent.com/29879453/158009641-9cf3975a-d63c-4c53-b0d3-8dfa73357fc0.png">


