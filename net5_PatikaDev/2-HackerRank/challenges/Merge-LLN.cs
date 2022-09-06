
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Xml.Linq;


namespace net5.hackerrank.challenges {

	internal class Merge_LLN {

		class Solution {

			class SLLN {
				public int data;
				public SLLN next;

				public SLLN ( int nodeData ) {
					this.data = nodeData;
					this.next = null;
					}
				}

			class SinglyLinkedList {
				public SLLN head;
				public SLLN tail;

				public SinglyLinkedList () {
					this.head = null;
					this.tail = null;
					}

				public void InsertNode ( int nodeData ) {
					SLLN node = new SLLN( nodeData );

					if ( this.head == null ) {
						this.head = node;
						}
					else {
						this.tail.next = node;
						}

					this.tail = node;
					}
				}

			//static void PrintSinglyLinkedList ( SLLN node, string sep, TextWriter textWriter ) {
			static void PrintSinglyLinkedList ( SLLN node, string sep ) {
				while ( node != null ) {
					Console.Write( node.data );

					node = node.next;

					if ( node != null ) { Console.Write( sep ); }
					}
				}

			// Complete the mergeLists function below.

			/*
			 * For your reference:
			 *
			 * SLLN {
			 *     int data;
			 *     SLLN next;
			 * }
			 *
			*/


			static SLLN MergeLists ( SLLN head1, SLLN head2 ) {
				if ( head1 == null ) { return head2; }
				else if ( head2 == null ) { return head1; }

				else if ( head1.data <= head2.data ) { head1.next = MergeLists( head1.next, head2 ); return head1; }
				else { head2.next = MergeLists( head1, head2.next ); return head2; }
				}



			static SLLN MergeLists4 ( SLLN headA, SLLN headB ) {
				// This is a "method-only" submission. 
				// You only need to complete this method 
				if ( headA == null ) return headB;
				else if ( headB == null ) return headA;
				else if ( headA.data <= headB.data ) {
					headA.next = MergeLists4( headA.next, headB );
					return headA;
					}
				else {
					headB.next = MergeLists4( headA, headB.next );
					return headB;
					}

				}

			static SLLN MergeLists3 ( SLLN currA, SLLN currB ) {
				if ( currA == null ) { return currB; }
				else if ( currB == null ) { return currA; }

				/* Find new head pointer */
				SLLN head = null;
				if ( currA.data < currB.data ) {
					head = currA;
					currA = currA.next;
					}
				else {
					head = currB;
					currB = currB.next;
					}

				/* Build rest of list */
				SLLN n = head;
				while ( currA != null && currB != null ) {
					if ( currA.data < currB.data ) {
						n.next = currA;
						currA = currA.next;
						}
					else {
						n.next = currB;
						currB = currB.next;
						}
					n = n.next;
					}

				/* Attach the remaining elements */
				if ( currA == null ) {
					n.next = currB;
					}
				else {
					n.next = currA;
					}

				return head;
				}

			static SinglyLinkedList llist1;
			static void Main ( string [ ] args ) {
				// TextWriter textWriter = new StreamWriter( @System.Environment.GetEnvironmentVariable( "OUTPUT_PATH" ), true );
				var ins = "1 3 1 2 3 2 13 14".Split().Select( s => int.Parse( s ) ).ToList();
				ins = "1 3 14 13 3 2 2 1".Split().Select( s => int.Parse( s ) ).ToList();
				ins = "1 3 1 2 3 2 13 14".Split().Select( s => int.Parse( s ) ).ToList();
				int tests = ins [ 0 ]; // Convert.ToInt32( Console.ReadLine() );

				for ( int testsItr = 0; testsItr < tests; testsItr++ ) {
					llist1 = new SinglyLinkedList();

					int llist1Count = ins [ 1 ]; // Convert.ToInt32( Console.ReadLine() );

					for ( int i = 0; i < llist1Count; i++ ) {
						int llist1Item = ins [ tests + 1 + i ]; // Convert.ToInt32( Console.ReadLine() );
						llist1.InsertNode( llist1Item );
						}

					SinglyLinkedList llist2 = new SinglyLinkedList();

					int llist2Count = ins [ 1 + ins [ 0 ] + ins [ 1 ] ]; // Convert.ToInt32( Console.ReadLine() );

					for ( int i = 0; i < llist2Count; i++ ) {
						int llist2Item = ins [ tests + llist1Count + 1 + 1 + i ]; // Convert.ToInt32( Console.ReadLine() );
						llist2.InsertNode( llist2Item );
						}

					SLLN llist3 = MergeLists4( llist1.head, llist2.head );

					// PrintSinglyLinkedList( llist3, " ", textWriter );
					// textWriter.WriteLine();
					PrintSinglyLinkedList( llist3, " " );
					Console.WriteLine();
					}

				// textWriter.Flush();
				// textWriter.Close();
				}


			static void Main1 ( string [ ] args ) {
				TextWriter textWriter = new StreamWriter( @System.Environment.GetEnvironmentVariable( "OUTPUT_PATH" ), true );

				int tests = Convert.ToInt32( Console.ReadLine() );

				for ( int testsItr = 0; testsItr < tests; testsItr++ ) {
					SinglyLinkedList llist1 = new SinglyLinkedList();

					int llist1Count = Convert.ToInt32( Console.ReadLine() );

					for ( int i = 0; i < llist1Count; i++ ) {
						int llist1Item = Convert.ToInt32( Console.ReadLine() );
						llist1.InsertNode( llist1Item );
						}

					SinglyLinkedList llist2 = new SinglyLinkedList();

					int llist2Count = Convert.ToInt32( Console.ReadLine() );

					for ( int i = 0; i < llist2Count; i++ ) {
						int llist2Item = Convert.ToInt32( Console.ReadLine() );
						llist2.InsertNode( llist2Item );
						}

					SLLN llist3 = MergeLists4( llist1.head, llist2.head );

					//PrintSinglyLinkedList( llist3, " ", textWriter );
					PrintSinglyLinkedList( llist3, " " );
					Console.WriteLine();
					}

				textWriter.Flush();
				textWriter.Close();
				}
			}
	
		}
	}

