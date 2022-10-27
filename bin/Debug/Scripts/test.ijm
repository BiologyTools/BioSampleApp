open(getArgument);
saveAs("Tiff",getArgument);
dir = getDir("startup");
File.saveString("done",dir + "done.txt");