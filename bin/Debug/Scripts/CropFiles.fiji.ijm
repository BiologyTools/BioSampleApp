dir = getDir("select a directory");
fileList = getFileList(dir);
for (i = 0; i < fileList.length; i++) {
	open(dir + fileList[i]);
	//add more code here to do something with the images/files
	makeRectangle(876, 604, 1000, 1000);
	run("Crop");
	saveAs("Tiff", dir + fileList[i]);
	close();
}
