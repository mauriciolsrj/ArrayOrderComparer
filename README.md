# ArrayOrderComparer

This is an exercise how to order an array according to other array.
Note: Details will not be provided here in order to keep the solution far form search engine results.

## Clone, build and test

```sh
git clone https://github.com/mauriciolsrj/ArrayOrderComparer
cd ArrayOrderComparer
dotnet build
dotnet test
```

## Usage
```sh

var individualsName = new string[] {
                "Sonia Maria Wood Dempster",
                "Laruen Ana Eagles Beneke",
                "Maurício Luís dos Santos",
                "Jorge Herrera"
            };

var desiredOrder = new int[]{ 1, 0, 3, 2};
individualsName.SortWithOrder(desiredOrder);
```

Result will be an array with the following order:

```
Laruen Ana Eagles Beneke
Sonia Maria Wood Dempster
Jorge Herrera
Maurício Luís dos Santos
```