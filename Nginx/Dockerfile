FROM nginx
COPY ["Nginx/conf.d/default.conf", "/etc/nginx/conf.d/default.conf"]
RUN apt-get update 
RUN apt-get install openssl
RUN mkdir /etc/nginx/ssl
RUN openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout /etc/nginx/ssl/microrabbit.mvc.key -out /etc/nginx/ssl/microrabbit.mvc.crt -subj "/C=MX/ST=YN/L=Merida/O=Ksquare/OU=Section/CN=localhost"