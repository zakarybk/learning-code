import React from "react"
import { StyleSheet, Text, View, Image, Dimensions } from "react-native"

import picMountain from "./assets/gray-asphalt-road-on-cliff.jpg"
import picCave from "./assets/abstract-antelope-canyon-art-blur.jpg"

export default function App(){
  return(
    <View style={styles.page}>
      <Image style={styles.image} source={picMountain} />
      <Image style={styles.image} source={picCave} />
    </View>
  )
} 

const styles = StyleSheet.create({
  page: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
  },
  image: {
    flex: 1,
    borderRadius: 50,
    margin: 10,
    width: Dimensions.get("window").width - 10
  },
})