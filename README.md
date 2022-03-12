# TechnicalAssessment

## Task1
#### Screenshot:


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


## Task3
Provided with a recursive function(getDescendants) that given a DOM element will return an array that contains the element itself and all its descendants.

@param 1. **element**: is the DOM element

@param 2. **arr**: is the array the function fills with childs elements and ultimately returns, there's no need to specify this param, unless you want to start with a non-empty array.
                
#### Example:
```
getDescendants(document.getElementById('bottomMenu'))
```

#### Screenshot:
