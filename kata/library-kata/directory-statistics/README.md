# Directory Statistics
Create a library that collects statistics about a directory tree. 

It should parse a directory tree and collect a couple of information:
* Amount of files contained
* Size of contained files
* Amount of directory levels (depth of directory structure)

Data colletion should start after the call of `start()`. It should be possible to pause and resume the collection of data. All information should be acummulated for all subdirectories. So each instance of IFolder always contains information about collected data of all subdirectories of this folder.

## Definition
```java
interface IFolderStats {
 void connect(string rootpath);
 
 void start();
 void stop();
 
 void pause();
 void resume();
 
 IList<IFolder> getFolders();
 string getRootPath();
 Statuses getStatus();
 
 event Action<IFolder> Progress;
}
 
interface IFolder {
 string getPath();
 long getNumberOfFiles();
 long getTotalBytes();
 int getDepth();
 IList<IFolder> getSubFolders();
}
 
enum Statuses {
 Waiting, // not connected yet
 Connected,
 Running,
 Paused,
 Finished
}
``` 
