#### This Repository Follow Pluralsight course for [C# Facade pattern](https://app.pluralsight.com/library/courses/csharp-design-patterns-facade)

##### Problem and Solution files:

You can See project files Example include the two Problems and their solution which apply Facade pattern Here:

  - **Ball Of Mud problem** under `ball_of_mud_problem` branch:
     - Problem at [facdce30f18a3d9e75b3a9936f13162a4af97e6b commit](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Facade/commit/facdce30f18a3d9e75b3a9936f13162a4af97e6b)
     - Solution at [56870904b86bf9ce58edbbca3752ee61ef55d65d commit](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Facade/commit/56870904b86bf9ce58edbbca3752ee61ef55d65d)
   
  - **The Worker Service Problem** under `the_worker_services_problem` branch:
     - Problem at [be440a8f003c3d915f3bc105e1135c60b0996fbc commit](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Facade/commit/be440a8f003c3d915f3bc105e1135c60b0996fbc)
     - Solution at [f787fe801f5eada946991ff4ead53d60b0639a94 commit](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Facade/commit/f787fe801f5eada946991ff4ead53d60b0639a94)
  
##### Run Problem or Solution Project:
 
You can Run Project using Docker, if you don't have Docker , you can install Docker Engine from [Here](https://docs.docker.com/engine/install)
 
 - First build docker image
 ```shell
docker build -t facadepattern .
```

 - Second run built image
 ```shell
docker run --name facadepattern facadepattern