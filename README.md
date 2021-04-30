# Obstacle avoidance using AVL tree 


## This package contains a C# namespace for obstacle avoidance

By using the Binary and Balancing property of AVL tree, this package manipulates different sensors.
Currently, the data structure contains a single Tri-Node which is suitable for system with 4 sensor.

### Contributers
#### Arif Islam
#### Andrew Kumley
#### Amin Alsultan


## List of CLasses and Methods

### Class Node

This class creates a node with two data field `<Value>` and `<Sensor>`. `<Value>` stores int trigger value from sensor(0/1) and `<Sensor>` stores the direction as a string type.


### Class AVL_BST

#### IsEmpty()

#### Clear()

#### AVL_Insert(int newVal, string sensor)

              // A recursive insert method for general purpose.
              // We dont need this for This project

#### Initialize(int SenvalRoot, string SenDirRoot, int SenvalLC , string SenDirLC, int SenvalRC, string SenDirRC)

             //The purpose of this method is to initialize the data structure with initial sensor values.
             //This structure is designed as a single tri-nodal structure for a robot with 4 sensors.
             //Initially 3 sensor values are required.

#### UpdatedSensorAdd(int senval, string sensor)

              // Add New Node to the leftchild. 

### ClockSingleRot()

            // CWSingle  clock wise single rotation
            
### PrintInOrder()
      
             // print in order


### Class Sensor



