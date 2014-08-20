FROM ubuntu:12.04
MAINTAINER Andreas Mosti, andreas.mosti@gmail.com

RUN apt-get update 
RUN apt-get -y -q install wget
RUN wget -q http://download.opensuse.org/repositories/home:tpokorra:mono/xUbuntu_12.04/Release.key -O- | apt-key add -
RUN apt-get remove -y --auto-remove wget

RUN sh -c "echo 'deb http://download.opensuse.org/repositories/home:/tpokorra:/mono/xUbuntu_12.04/ /' >> /etc/apt/sources.list.d/mono-opt.list"

RUN apt-get -q update
RUN apt-get -y -q install mono-opt

CMD ["/bin/bash", "-c", "/opt/mono/bin/mono --version|grep Mono"]
