FROM openjdk:16-jdk-alpine

WORKDIR /api
COPY . /api

RUN cd /api
RUN apk add bash
RUN bash gradlew build

ENTRYPOINT [ "java", "-jar", "build/libs/rest-0.0.1-SNAPSHOT.jar" ]