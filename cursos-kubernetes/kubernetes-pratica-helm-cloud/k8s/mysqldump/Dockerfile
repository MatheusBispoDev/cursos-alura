FROM mysql 
COPY dump.sh /
RUN chmod +x /dump.sh
ENTRYPOINT ["/dump.sh"]