FROM openjdk:16-jdk-alpine
VOLUME ./msprjava:/
ARG JAR_FILE
COPY ${JAR_FILE} app.jar
ENTRYPOINT ["java","-jar","/app.jar"]