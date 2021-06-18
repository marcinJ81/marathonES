## Application to cycle marathon 
This project is an exercise based on a DNA course.
[Description of the task](https://ismartdev.pl/dna-zadania/esdl/)
### Authors of Event Storming Design Level :
-  [Jakub Wi¹cek](https://www.linkedin.com/in/jakub-wi%C4%85cek-512551b6/ "Jakub Wiacek")
-  [Tomasz Szlêk](https://www.linkedin.com/in/tomasz-szlek-275653169/ "Tomasz Szlek")
-  [Dawid Perdek](https://www.linkedin.com/in/perdekdawid/ "Dawid Perdek")
-  [Marcin Juranek](https://ismartdev.pl "Marcin Juranek")

### Bounded  context *Generating Starting Groups*

#### Event Change Group
**Rules:**
- Deadline  for generating groups not exceeded
- Target group have free places
- Participant not change group before
- Target group have the same distance
- Starting groups has been generated

[![](https://github.com/marcinJ81/marathonES/blob/master/images/change_group.jpg)](https://github.com/marcinJ81/marathonES/blob/master/images/change_group.jpg "Change Group")

#### Event Generating Starting Groups
**Rules:**
- Starting groups no yet generated
- There are at least X participants with starting numbers
- The deadline for generating groups set out in the regulations has not been exceeded

[![](https://github.com/marcinJ81/marathonES/blob/master/images/generate_groups.jpg)](https://github.com/marcinJ81/marathonES/blob/master/images/generate_groups.jpg "Generate Groups")