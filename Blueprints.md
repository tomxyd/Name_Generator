# Blueprints for Name Generator console App

## Essentails

-    Generate Name from sample prefix and suffix

## Non-Essentials

-    None.

## Entities

-    [Name sources for prefix and suffix](https://www.angelfire.com/rpg2/vortexshadow/names.html)

## Flow-Chart

0.   User runs program.
1.          Generate Name.

-    Prefix and Suffix source.
     **PSEUDO** :
     ```
     list suffix;
     list prefix;
     ```
-    Randomly pick from a prefix list and a suffix and add together to get a name.
     **PSEUDO** :
     ```
      GenerateName()
      {
          return prefix.random + suffix.random;
      }
     ```

2.   Genrate Full Name.

     **PSEUDO** :

     ```
     GenerateFullName()
     {
         //add two names together
         firstName = GenerateName();
         lastName = GenerateName();
         return "firstName lastName".
     }
     ```

## Time Estimation

_DEADLINE_ : Saturday.
