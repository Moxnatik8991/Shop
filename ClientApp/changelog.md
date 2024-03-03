# 03.03.24

## New installations:

- _**SASS**_; now we can use .scss in project (it is much more convenient than plain css)
- _**Redux**_; still playing with it, it's connected, but now it affects only pages/_tmpPages/CatalogRedux


## Changes:

- brought Header and Footer into separate components
- brought pages in separate folder

### App.js:


- got rid of grid in .appContainer, replaced it with flex (grid is not so flexible, in future may be difficult to maintain)
- added container for pages content to cover all viewport 

### Header

- replaced grid with flex