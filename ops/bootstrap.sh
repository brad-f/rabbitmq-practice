sudo apt-get update
/etc/apt/sources.list >> deb http://www.rabbitmq.com/debian/ testing main
sudo apt-get update
sudo apt-get install -y rabbitmq-server
sudo /usr/lib/rabbitmq/lib/rabbitmq_server-2.7.1/sbin/rabbitmq-plugins enable rabbitmq_management
sudo service rabbitmq-server restart


