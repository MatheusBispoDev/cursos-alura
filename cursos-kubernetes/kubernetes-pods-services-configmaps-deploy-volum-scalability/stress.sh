#!/bin/bash
for i in {1..10000}; do
    curl 192.168.49.2:30001
    sleep $1
done
