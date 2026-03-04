# Use lightweight nginx image
#FROM nginx:alpine

# Remove default nginx content
#RUN rm -rf /usr/share/nginx/html/*

# Copy your custom index file
#COPY index.html /usr/share/nginx/html/

# Expose port 80
#EXPOSE 80

# Run nginx in foreground
#CMD ["nginx", "-g", "daemon off;"]

# Example testing Dockerfile
# Based on a minimal Alpine image, prints a message at startup.

FROM alpine:3.18

# Add a simple startup script
RUN echo '#!/bin/sh' > /start.sh \
    && echo 'echo "Hello from test image"' >> /start.sh \
    && chmod +x /start.sh

# Default command
CMD ["/start.sh"]
