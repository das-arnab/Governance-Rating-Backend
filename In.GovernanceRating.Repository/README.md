# Refactoring notes

### We need to seperate the Repository contracts to a seperate file in future.  

Project structure could be:
**DataAccess**
 -- In.GovernanceRating.Repository
    [This will contain the dbContexts and the Repository implementations]
 -- In.GovernanceRating.Repository.Contract
    [This will contain interfaces]


### Analysis needed in future for number of repository classes

We could have one repository for multiple related entities. This would reduce the clutter. Too much seperation of concern can cause a lot of clutter.