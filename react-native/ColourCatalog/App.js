import React from "react"
import { StyleSheet, Text, View } from "react-native"

import picMountain from "./assets/gray-asphalt-road-on-cliff.jpg"

export default function App(){
  return(
    <View style={styles.page}>
      <Text style={[styles.text, styles.selectedText]}>Red</Text>
      <Text style={styles.text}>Green</Text>
      <Text style={styles.text}>Blue</Text>
    </View>
  )
} 

const styles = StyleSheet.create({
  page: {
    flex: 1,
    flexDirection: "column",
    justifyContent: "space-around",
    alignItems: "flex-start",
    marginTop: 40,
    backgroundColor: "#DDD"
  },
  text: {
    textAlign: "center",
    fontSize: 22,
    color: "red",
    backgroundColor: "yellow",
    margin: 10,
    padding: 5
  },
  selectedText: {
    alignSelf: "flex-end",
    backgroundColor: "red",
    color: "yellow"
  }
})