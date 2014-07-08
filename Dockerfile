FROM andmos/mono
MAINTAINER Andreas Mosti, andreas.mosti@gmail.com

ADD HelloWorldProject/bin/Debug .
CMD /opt/mono/bin/mono `ls *.exe | head -1` 

