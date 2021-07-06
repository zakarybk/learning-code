FROM node:10 AS node

WORKDIR usr/src/app

COPY package*.json ./
RUN npm install

FROM node AS installed_packages

ENV NODE_ENV=production

COPY . .

RUN npm run build

CMD npm start